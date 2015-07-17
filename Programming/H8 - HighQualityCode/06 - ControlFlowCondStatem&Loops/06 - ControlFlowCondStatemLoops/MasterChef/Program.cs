using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Chef ()
    {
        private Bowl GetBowl()
        {   
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            //...
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}

/*

 public class Chef
{
    private Bowl GetBowl()
    {   
        //... 
    }
    private Carrot GetCarrot()
    {
        //...
    }
    private void Cut(Vegetable potato)
    {
        //...
    }  
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Bowl bowl;
        Peel(potato);

        Peel(carrot);
        bowl = GetBowl();
        Cut(potato);
        Cut(carrot);
        bowl.Add(carrot);

        bowl.Add(potato);
    }
    private Potato GetPotato()
    {
        //...
    }
}
 
 */