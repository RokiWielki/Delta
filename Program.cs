//Napisz program, który oblicza deltę dla równania kwadratowego ax^2+bx+c=0
//Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
//Wzór: (delta)=b^2-4ac


using System;

namespace Delta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation: ax^2+bx+c=0");
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Delta is: "+Delta(a, b, c));;
        }
        static double Delta(double a,double b, double c)
        {
            double result = b * b - 4 * a * c;
            return result;
        }
    }
}
