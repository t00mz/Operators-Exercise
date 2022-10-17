using System.Reflection.Metadata.Ecma335;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4);
            {

                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            }

            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)
         {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
         
        
    }
}