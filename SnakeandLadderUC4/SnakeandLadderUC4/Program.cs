using System;

namespace SnakeandLadderUC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sanke and Ladder game");
            int position = 0;
            int NoOfDieroll = 0;
            Random ran = new Random();
            while(position<=100)
            {
                int number = ran.Next(0, 7);
                NoOfDieroll++;
                Console.WriteLine("Number of die rolls : " + NoOfDieroll);
                int option = ran.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play");
                        Console.WriteLine("The Position is : " + position);
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position = position + number;
                        Console.WriteLine("The Position is : " + position);
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position = position + number;
                        Console.WriteLine("The Position is : " + position);
                        break;

                }
            }
            
        }
    }
}
