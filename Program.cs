using System.Dynamic;

namespace day2_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("please enter  num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter num3");
            num3= Convert.ToInt32(Console.ReadLine());
            int largest = num1;
            if (largest > num2)
            {
                largest = num2;

            }
            if (largest < num3)
            {
                largest = num3;

            }
            Console.WriteLine($" the laragest number is !{ largest}" );

                


        }
    }
}
