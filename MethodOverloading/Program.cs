using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(6.57m, 5.32m, true);
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;
            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars");
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
