using System;

namespace C_Sharp_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Bob";
            int mail = 3;
            decimal temeprature = 34.4m;
            Console.WriteLine("Hello, {0}! You have {1} in inbox.  Temperaure id {2} celsius", name, mail, temeprature);
            string s = $"Hello, {name}! You have {mail} in inbox.  Temperaure id {temeprature} celsius";
            Console.WriteLine(s);

        }
    }
}
