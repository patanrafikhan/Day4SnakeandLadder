using System;
using System.Security.Cryptography;

namespace SnakeandLadderUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and Ladder Game");

            
            
            bool playAgain = true;
            int position = 0;
            int NoOfDiceroll = 0;
            int rafi;
            int num=0;

            while (playAgain )
            {
                rafi = 0;
                Random ran = new Random();
                num =  ran.Next(num);
                
                while(rafi !=num)
                {
                    Console.WriteLine("rafi) is start position :" + position + " - " + NoOfDiceroll +" - ");
                    rafi=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("rafi : " + rafi);

                    if (rafi> num)
                    {
                        Console.WriteLine(rafi<0);
                    }
                    else
                    {
                        Console.ReadLine();
                    }

                }
                Console.WriteLine("Sigle Player Position is :" + num);
                break;

            }
            

        }
    }
}
