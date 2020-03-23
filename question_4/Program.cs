/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Switches
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgOne;
            string msgTwo;
            Console.WriteLine("Enter the card notation : ");
            string notation = Console.ReadLine();
            notation = notation.ToUpper();

            switch (notation[0])
            {
                case 'A':
                    msgOne = "Ace";
                    break;

                case 'Q':
                    msgOne = "Queen";
                    break;

                case 'K':
                    msgOne = "King";
                    break;

                case 'J':
                    msgOne = "Jack";
                    break;

                case '2':
                    msgOne = "Two";
                    break;

                case '3':
                    msgOne = "Three";
                    break;

                case '4':
                    msgOne = "Four";
                    break;

                case '5':
                    msgOne = "Five";
                    break;

                case '6':
                    msgOne = "Six";
                    break;

                case '7':
                    msgOne = "Seven";
                    break;

                case '8':
                    msgOne = "Eight";
                    break;

                case '9':
                    msgOne = "Ten";
                    break;

                default:
                    msgOne = "Error";
                    break;



            }
            switch (notation[1])
            {
                case 'D':
                    msgTwo = " of Diamonds";
                    break;

                case 'S':
                    msgTwo = " of Spades";
                    break;

                case 'H':
                    msgTwo = " of Hearts";
                    break;

                case 'C':
                    msgTwo = " of Clubss";
                    break;

                default:
                    msgTwo = "error";
                    break;
            }
            Console.WriteLine("{0} {1}", msgOne, msgTwo);
        }
    }
}
