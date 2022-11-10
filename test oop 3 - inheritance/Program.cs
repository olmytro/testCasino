using System;

namespace test_oop_3___inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option: 1- easy, 2- medium, 3- hard");
            string choice= Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose an easy difficult");
                    int Try = 5;
                    break;
                case "2":
                    Console.WriteLine("You chose a medium difficult");
                    int Try = 3;
                    break;
                case "3":
                    Console.WriteLine("You chose a hard difficult");
                    int Try = 1;
                    break;
            }
            
            

            Random rnd = new Random();
            int secret = rnd.Next(0, 10);
            
            Console.WriteLine("Write your number: ");
            
            for (int i = 0; i < Try; i++) 
            {
                int myNumber = Convert.ToInt32(Console.ReadLine());

                if (myNumber == secret)
                {
                    Console.WriteLine("You win.");
                    Console.WriteLine($"Result was: {secret}");
                    break;
                }
                else 
                {
                    Console.WriteLine($"Wrong number. Write again. Осталось попыток:");
                    Console.WriteLine(Try - i); // но i начинается с 0, нужно сделать чтобы отнимался i после коннактации.
                }
            }
            
            /*do
            {
                Console.Write("write number: ");
                int numb = Convert.ToInt32(Console.ReadLine());

                if (numb == i)
                {
                    Console.WriteLine("You win.");
                    Console.WriteLine($"Result was: {i}");
                    break;
                }
                else
                {
                    Console.WriteLine("You are lost. Write again");
                    Count--;
                }

            }
            while (Count > 0);*/


            Console.ReadKey();

        }
    }
}
