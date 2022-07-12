namespace Day3_LineComparision
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");
            UC2_EqualLengths comp = new UC2_EqualLengths();
            double Ans1 = comp.LengthLine1();
            double Ans2 = comp.LengthLine2();


            if (Ans1 == Ans2)
            {
                Console.WriteLine("lengths are equal");
            }
            else
            {
                Console.WriteLine("lengths are not equal");
            }
            
        }
    }
}
