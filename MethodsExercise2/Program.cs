using System;

namespace MethodsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region writelines
            /*Console.WriteLine(Add(3, 6));
              Console.WriteLine(Subtract(8, 4));
              Console.WriteLine(Multiply(12, 24));
              Console.WriteLine(Divide(12, 6));
              Console.WriteLine(Modulus(25, 6));*/
            #endregion


            Console.WriteLine(Sum(2, 5, 7, 8));



        }
        #region calculate methods1
        /*public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }*/
        #endregion


        public static int Sum(params int[] nums)
        {
            var sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }





    }
}
