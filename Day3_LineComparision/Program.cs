namespace Day3_LineComparision
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");
            UC3_LengthsComparision comp = new UC3_LengthsComparision();
            double Ans1 = comp.LengthLine1();
            double Ans2 = comp.LengthLine2();


            if (Ans1 == Ans2)
            {
                Console.WriteLine("lengths are equal");
            }
            else if (Ans1 < Ans2)
            {
                Console.WriteLine("one length is less than another length");
            }
            else if (Ans1 > Ans2)
            {
                Console.WriteLine("one leghth is greater than another length");
            }
            else 
            { 
                Console.WriteLine("lengths are not equal");
            }
            
        }
    }
}
