using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3NDV
{
    class Program
    {
        static void Main(string[] args)
        {
            string Awn;
            do
            {
                Class1 Calc = new Class1();
                Console.WriteLine("Learn your squres and cubes\n");


                Console.WriteLine("Enter an Integer:");
                string InPut = Console.ReadLine();
                int InPutNum = int.Parse(InPut);


                int InPutNum2 = 1;
                Console.WriteLine("Number      Squered       Cubed");
                Console.WriteLine("======      =======       =====");

                for (int i = 0; i < InPutNum; i++)
                {
                    Console.WriteLine(InPutNum2 +
                            "           "
                            + Calc.square(InPutNum2)
                            + "          "
                            + Calc.cube(InPutNum2));
                    InPutNum2++;
                }
                Console.WriteLine("Continue? (y/n)");
                Awn = Console.ReadLine();
            } while (Awn == "y");






        }
    }
}
