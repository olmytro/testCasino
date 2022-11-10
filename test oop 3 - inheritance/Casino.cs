using System;
using System.Collections.Generic;
using System.Text;

namespace test_oop_3___inheritance
{
    class Casino
    {
        public int Choose;

        public void EasyFor()
        {
            Choose = 5;
            Random rnd = new Random();
            int secret = rnd.Next(0, 10);

            Console.WriteLine("Write your number: ");

            for (int i = 0; i < Choose; i++)
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
                    Console.WriteLine(Choose - i - 1); // но i начинается с 0, нужно сделать чтобы отнимался i после коннактации.
                }
            }
        }
        
        public void EasyDo()
        {
            Choose = 5;
            Random rnd = new Random();
            int secret = rnd.Next(0, 10);
            do
            {
                Console.WriteLine("Write your number: ");
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
                    Choose--;
                    //Console.WriteLine(Choose - i -1);
                }
            }
            while (Choose > 0);
        }
    }
}
