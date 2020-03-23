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

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg; 
            Console.WriteLine("Please enter your score : ");
            int score = int.Parse(Console.ReadLine());
            score = score / 10; 
            switch(score)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    msg = "don’t give up the day job dude";
                    break;

                case 5:
                case 6:
                    msg = "back to the training ground dude";
                    break;

                case 7:
                    msg = "Your good dude";
                    break;

                case 8:
                case 9:
                case 10:
                    msg = "Awesome dude";
                    break;

                default:
                    msg = "error";
                    break;



            }
            Console.WriteLine(msg);
        }
    }
}
