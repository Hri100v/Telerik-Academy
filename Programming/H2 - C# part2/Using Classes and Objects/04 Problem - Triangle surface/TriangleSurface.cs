/*Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
o Side and an altitude to it;
o Three sides;
o Two sides and an angle between them;
 * 
Use System.Math.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _04_Problem___Triangle_surface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose how to calculate surface of a triangle by given.\nSide and an altitude to it - choose (1).\nThree sides - choose (2).\nTwo sides and an angle between them - choose (3).");
            //Console.WriteLine(Math.Sin(2.5));

            int choice;     // = int.Parse(Console.ReadLine())
            //Thread.Sleep(4000);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,15}",4 - i);
                Thread.Sleep(900);
            }
            Console.Clear();

            do
            {
                Console.WriteLine("Choises:");
                Console.WriteLine();
                Console.WriteLine(" 1. Side and an altitude to it - 1");
                Console.WriteLine(" 2. Three sides - 2");
                Console.WriteLine(" 3. Two sides and an angle between them - 3");
                Console.WriteLine(" 0. EXIT");
                Console.WriteLine();
                Console.Write("CHOOSE: ");

                bool testChoice = int.TryParse(Console.ReadLine(), out choice);
                if (testChoice == false)
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Side and an altitude to it - 1");
                        Console.Write("Write side: "); 
                            int side = int.Parse(Console.ReadLine()); 
                        Console.Write("Write altitude: "); 
                            int altitude = int.Parse(Console.ReadLine()); 
                        TriangleSurfSideAltitude(side, altitude);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Three sides - 2");
                        Console.Write("Write side A: "); 
                            double a = double.Parse(Console.ReadLine()); 
                        Console.Write("Write side B: "); 
                            double b = double.Parse(Console.ReadLine());  
                        Console.Write("Write side C: "); 
                            double c = double.Parse(Console.ReadLine()); 
                         
                        TriangleSurfThreeSides(a, b, c);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Two sides and an angle between them - 3");
                        Console.Write("Write side A: ");
                            double sideA = double.Parse(Console.ReadLine()); 
                        Console.Write("Write side B: ");
                            double sideB = double.Parse(Console.ReadLine());
                            Console.Write("Write angle between them: ");
                            double alphaAB = double.Parse(Console.ReadLine());

                        TriangleSurf2SidesAngle(sideA, sideB, alphaAB);
                        Console.WriteLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong entry");
                        Console.WriteLine();
                        break;
                }

            } while (choice != 0);

            
        }

        // S = a * h
        private static void TriangleSurfSideAltitude(int side, int altitude)
        {
            double result = side * altitude;
            Console.WriteLine("Surface = {0:F3}", result);
        }

        //S = √[p(p - a)(p - b)(p - c)] - Херонова формула
        private static void TriangleSurfThreeSides(double a, double b, double c)
        {
            double p = a + b + c;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Surface = {0:F3}", result);
        }

        //S = ½(ab.sinC) = ½(ac.sinB) = ½(bc.sinA)
        private static void TriangleSurf2SidesAngle(double sideA, double sideB, double alphaAB)
        {
            //degree = ... #        30 / 180 = 1/6   =>   sin(п * 1/6) =>   sin(п/6)        # 2п = 360
            double sinC = Math.Sin((Math.PI * (alphaAB / 180)));
            double result = 0.5 * (sideA * sideB * sinC);
            Console.WriteLine("Surface = {0:F3}", result);
        }

        //S = R2sinA.sinB.sinC = abc/4R  -  за по-нататък
    }
}
