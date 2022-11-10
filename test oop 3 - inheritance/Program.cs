using System;

namespace test_oop_3___inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Casino cas = new Casino();
            Console.WriteLine("Select option: 1- easy, 2- medium, 3- hard");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose an easy difficult");
                    //cas.EasyDo();
                    cas.EasyFor();
                    break;
                case "2":
                    Console.WriteLine("You chose a medium difficult");
                   // int Try = 3;
                    break;
                case "3":
                    Console.WriteLine("You chose a hard difficult");
                    //int Try = 1;
                    break;
            }

            Console.ReadKey();

        }
    }
}
