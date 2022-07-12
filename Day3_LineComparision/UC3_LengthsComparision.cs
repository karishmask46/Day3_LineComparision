using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LineComparision
{
    internal class UC3_LengthsComparision
    {
        public double LengthLine1()
        {
            Console.WriteLine(" enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(length1);
            return length1;
        }
        public double LengthLine2()
        {
            Console.WriteLine(" enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double length2 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(length2);
            return length2;
        }

    }
}
