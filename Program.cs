using System;
using System.Text;
using NetCoreWorkshop_4_27_18.Math;

namespace NetCoreWorkshop_4_27_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string entered = "";
            while (!entered.ToLower().Equals("exit"))
            {
                Console.WriteLine("How many iterations to calculate Square? (Type 'Exit' to cancel)");

                entered = Console.ReadLine();
                Console.WriteLine("Entered: " + entered);
                //Console.WriteLine(entered);
                int iterations = new StringToIntConverter(entered).Success ?
                                new StringToIntConverter(entered).Result :
                                0;

                string resultOutput = "";
                for (int i = 1; i <= iterations; i++)
                {
                    int squared = new Squared(i).Result;
                    resultOutput += (i * i).ToString() + (i == iterations ? "" : ", ");
                }

                Console.WriteLine(resultOutput.ToString());
            }
        }
    }
}
