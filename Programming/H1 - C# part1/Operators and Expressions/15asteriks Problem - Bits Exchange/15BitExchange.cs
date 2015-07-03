/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
Examples:

n	        binary representation of n	            binary result	                        result
1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
255406592	00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
5351	    00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	    67114183
2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705
            8      1 8      1 8      1 76543210
 */

using System;

    class BitExchange
    {
        static void Main()
        {

            Console.WriteLine("Modify a Bit at Given Position");
            Console.WriteLine("Enter some number: ");
            string num = Console.ReadLine();
            int a = int.Parse(num);
            Console.Write("Binary representation of {0} is: ", num);
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));

            Console.WriteLine("Change bit position exchanges bits 3, 4 and 5 with bits 24, 25 and 26.");

            //      80000001 80000001 80000001 76543210
            //      00000wvu 00000000 00000000 00zyx000
            //  #   01000100 00000000 01000000 00010101
            //           010                     100
            //  >   01000010 00000000 01000000 00100101

            ushort pos3 = 3;    //x       ->    #(0 or 1)
            ushort pos4 = 4;    //y       ->    #(0 or 1)
            ushort pos5 = 5;    //z       ->    #(0 or 1)
                                                
            ushort pos24 = 24;  //u       ->    #(0 or 1)
            ushort pos25 = 25;  //v       ->    #(0 or 1)
            ushort pos26 = 26;  //w       ->    #(0 or 1)

            int mask;   //use for all 'pos'
            int AndMask;
/**/
            //bit3
            int mask3 = 1 << pos3;
            AndMask = a & mask3;
            int bit3 = AndMask >> pos3;

            //bit4
            int mask4 = 1 << pos4;
            AndMask = a & mask4;
            int bit4 = AndMask >> pos4;

            //bit5
            int mask5 = 1 << pos5;
            AndMask = a & mask5;
            int bit5 = AndMask >> pos5;

            //bit24
            int mask24 = 1 << pos24;
            AndMask = a & mask24;
            int bit24 = AndMask >> pos24;

            //bit25
            int mask25 = 1 << pos25;
            AndMask = a & mask25;
            int bit25 = AndMask >> pos25;

            //bit26
            int mask26 = 1 << pos26;
            AndMask = a & mask26;
            int bit26 = AndMask >> pos26;

            // chagnges     bit3 <-> bit24 [] bit4 <-> bit25 [] bit5 <-> bit26

            int changeNumber = a;
            int newNumber = changeNumber;

            //bit3 and bit24
            if (bit3 != bit24)
            {
                if (bit24 == 0)                     // =>    bit3 = 1
                {

                    //int changeNumber;
                    changeNumber = a | mask24;      //change bit24 = 0 with 1
                    //Console.WriteLine(Convert.ToString(changeNumber, 2).PadLeft(32, '0'));

                    changeNumber = ~changeNumber | mask3;    //change bit3 = 1 with 0
                    //Console.WriteLine(Convert.ToString(mask3, 2).PadLeft(32, '0'));
                    //Console.WriteLine(Convert.ToString(changeNumber, 2).PadLeft(32, '0'));
                    
                    changeNumber = ~changeNumber;
                    Console.WriteLine(Convert.ToString(changeNumber, 2).PadLeft(32, '0'));
                    Console.WriteLine(changeNumber);
                    newNumber = changeNumber;
                }
                else        // => bit24 = 1  => bit3 = 0
                {

                    changeNumber = ~a | mask24;
                    changeNumber = ~changeNumber;
                    changeNumber = changeNumber | mask3;
                    newNumber = changeNumber;
                }
                //Console.WriteLine("NOT=");
                //Console.WriteLine(changeNumber);
            }

            Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
            //bit4 and bit25
            if (bit4 != bit25)
            {
                if (bit25 == 0)                     // =>    bit4 = 1
                {
                    changeNumber = newNumber | mask25;      //change bit25 = 0 with 1
                    changeNumber = ~changeNumber | mask4;    //change bit4 = 1 with 0
                    changeNumber = ~changeNumber;
                    
                    newNumber = changeNumber;
                }
                else        // => bit25 = 1  => bit4 = 0
                {

                    changeNumber = ~newNumber | mask25;
                    changeNumber = ~changeNumber;
                    changeNumber = changeNumber | mask4;
                    newNumber = changeNumber;
                }

            }

            Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));

            //bit5 and bit26
            if (bit5 != bit25)
            {
                if (bit26 == 0)                     // =>    bit5 = 1
                {
                    changeNumber = newNumber | mask26;       //change bit26 = 0 with 1
                    changeNumber = ~changeNumber | mask5;    //change bit5 = 1 with 0
                    changeNumber = ~changeNumber;

                    newNumber = changeNumber;
                }
                else        // => bit26 = 1  => bit5 = 0
                {

                    changeNumber = ~newNumber | mask26;
                    changeNumber = ~changeNumber;
                    changeNumber = changeNumber | mask5;
                    newNumber = changeNumber;
                }
            }



            //new number printed below
            Console.WriteLine("binary result:");
            Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("result:");
            Console.WriteLine(newNumber);

        }       
    }