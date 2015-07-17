using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main()
        {
            // First part of this task2
            {
                Potato potato;

                //... 

                if (potato == null)
                    throw new ArgumentException();

                if (potato.HasNotBeenPeeled)
                    throw new ArgumentException("Potato has not been peeled!");

                if (potato.IsRotten)
                    throw new ArgumentException("Potato is rotten!");

                Cook(potato);
            }

            // Second part of this task2
            {
                public bool IsInside(int x, int y) 
                {
                    bool result = false;

                    if (x >= MIN_X && x =< MAX_X) &&
                       (MAX_Y >= y && MIN_Y <= y)
                    {
                        result = true;
                    }

                    return result;
                }

                public bool Visited(int x, int y)
                {
                    // ...
                    return true;
                }

                public static void MakeAction(int x, int y)
                {
                    if (IsInside(x, y) && !Visited(x, y))
	                {
		                VisitCell();
	                }
                }
            }

        }
    }
}


/*
 Potato potato;
//... 
if (potato != null)
   if(!potato.HasNotBeenPeeled && !potato.IsRotten)
    Cook(potato);
 * 
and

if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
{
   VisitCell();
}
 */