
using System;

namespace Formatter
{
    class ConvertRadianToDegree
    {
        static void Main(string[]args)
        {
         double radians=double.Parse(Console.ReadLine());
         double degree=radians*(180/Math.PI);
         degree=Math.Round(degree);
         Console.WriteLine(degree);
        }
    }
}