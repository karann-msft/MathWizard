using MathWizardHelper;
using System;

namespace MathWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            Operations operation = new Operations();
            var c = operation.Multiply(float.Parse(a), float.Parse(b));
            Console.WriteLine("{0} * {1} = {2}", a, b, c);

        }
    }
}
