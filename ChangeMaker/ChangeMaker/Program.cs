using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void ChangeMaker(float amount)//takes input and outputs its value in coins
        {
            float x = amount; //a var to be changed as it is asigned to coins
            int quarters = 0; //var to hold number of coins set to zero
            int dimes = 0;    //var to hold number of coins set to zero
            int nickels = 0;  //var to hold number of coins set to zero
            int pennies = 0;  //var to hold number of coins set to zero
                //
                while (x > 0.25f)//loops until there is less than a quarter
                {
                    x = x -  0.25f;//takes .25
                    quarters++;
                }


                while (x > 0.10f)//loops until there is less than a dime
                {
                    x = x - 0.10f;//takes .10
                    dimes++;
                }

                while (x > .05f)//loops until there is less than a nickel
                {
                    x = x - .05f;//takes .05
                    nickels++;
                }


                while (x > .00f)//loops until there is nothing left
                {
                    x = x - .01f;//takes .01
                    pennies++;
                }
            //prints
            Console.WriteLine("Amount: $"+amount);
            Console.WriteLine("Quarters: "+quarters);
            Console.WriteLine("Dimes: "+dimes);
            Console.WriteLine("Nickels :"+nickels);
            Console.WriteLine("Pennnies :"+pennies);
        }
        
        static void Main(string[] args)
        {

            ChangeMaker(3.18f);
            ChangeMaker(0.99f);
            ChangeMaker(12.93f);

            Console.ReadKey();
        }
    }
}

