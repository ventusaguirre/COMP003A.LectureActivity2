using System.Collections;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");

            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();
            double first = double.Parse(firstNumber);

            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine(); 
            double second = double.Parse(secondNumber);
            Console.WriteLine("");


            Console.WriteLine("Concatenation");
            double sum = first + second;
            Console.Write("Sum: " );
            Console.WriteLine(sum);
            double avg = (first + second) / 2;
            Console.Write("Average: ");
            Console.WriteLine(avg);

            Console.WriteLine("");


            Console.WriteLine("Interpolation");
            
            Console.WriteLine($"Sum: ");
            
            Console.WriteLine($"Average: ");

            Console.WriteLine("");


            Console.WriteLine("Comparisons");
            // greater/less than

            // equal to/not equal to


        }
    }
}
