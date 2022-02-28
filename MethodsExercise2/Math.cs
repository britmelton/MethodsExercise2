using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    public class Math
    {
        //Write different methods that use each math operator but allow you to plug in different integers. 
        public static int Add(int num1, int num2)
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
        }

        //Challenge mode: Change the functions to use the params keyword to support a range of arguments.

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
