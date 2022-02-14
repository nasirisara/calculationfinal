using System;

namespace calculationfinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i < int.MaxValue)
            {

                Console.WriteLine("please insert num1");
                string strnum1 = Console.ReadLine();

                Console.WriteLine("please insert +, -, *,/ as operators!");
                string opera = Console.ReadLine();

                Console.WriteLine("please insert num2");
                string strnum2 = Console.ReadLine();





                double num1, num2;
                num1 = double.Parse(strnum1);
                num2 = double.Parse(strnum2);





                switch (opera)
                {
                    case "+":
                        Console.WriteLine (Addition (num1 , num2));
                        break;


                    case "-":
                        Console.WriteLine(substraction(num1, num2));
                        break;

                    case "/":
                        {
                            if (num2 == 0)
                                Console.WriteLine("invalid number");
                            else
                                Console.WriteLine(division(num1 ,num2));
                            break;
                        }



                    case "*":
                        Console.WriteLine(multiple(num1 , num2));
                        break;

                }
                i++;
            }


            Console.ReadKey();



        }
        public static double Addition(double num1, double num2)

        {
            double sum = num1 + num2;
            return sum;
        }

        public static double substraction(double num1, double num2)

        {
            double minus  = num1  - num2;
            return minus;
        }

        public static double division (double num1, double num2)

        {
            double divide  = num1/num2;
            return divide;
        }

        public static double multiple (double num1, double num2)

        {
            double multi = num1 * num2;
            return multi;
        }

    }

}
   