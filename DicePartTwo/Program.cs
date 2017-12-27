using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicePartTwo
{
    //This is a program that lets you chose between different kinds of dice to roll
    class Program
    {
        static void Main(string[] args)
        {
            string diceType = "";
            Random diceNum = new Random();

            int numEnd = 0;

            System.Console.WriteLine("What kind of dice do you want to roll(4, 6, 8, 10 , 12, 20)");
            diceType = System.Console.ReadLine();
            System.Console.WriteLine("You picked: " + diceType);

            switch (diceType)
            {
                case "4":
                    numEnd = diceNum.Next(1, 5);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                case "6":
                    numEnd = diceNum.Next(1, 7);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                case "8":
                    numEnd = diceNum.Next(1,9);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                case "10":
                    numEnd = diceNum.Next(1, 11);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                case "12":
                    numEnd = diceNum.Next(1, 13);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                case "20":
                    numEnd = diceNum.Next(1, 21);
                    System.Console.WriteLine("You Rolled: " + numEnd);
                    break;

                default:
                    System.Console.WriteLine("Not a Valid dice Type");
                    break;
            }
        }
    }
}
