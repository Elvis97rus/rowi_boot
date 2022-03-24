using System;

namespace c__Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string l = "33";
            int a = int.Parse(l);
            string rl = Console.ReadLine();
            Console.WriteLine(rl);

            string str = "5.5";
            double d = Convert.ToDouble(str);
            Console.WriteLine(d);

            string test2 = "1sdfs";
            int test;
            bool parseB = int.TryParse(test2, out test);
            if (parseB) { Console.WriteLine(test); } else { Console.WriteLine("NOT PARSED"); }
            try
            {
                int ss = Convert.ToInt32("3sgs");
            }
            catch (Exception)
            {
                Console.WriteLine("An err occured");
            }
        }
    }
}

