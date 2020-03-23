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

namespace Switches_
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            string msg;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Please enter a number from 1 to 7: ");
                day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        msg = "Monday";
                        break;

                    case 2:
                        msg = "Tuesday";
                        break;

                    case 3:
                        msg = "Wednesday";
                        break;

                    case 4:
                        msg = "Thursday";
                        break;

                    case 5:
                        msg = "Friday";
                        break;

                    case 6:
                        msg = "Saturday";
                        break;

                    case 7:
                        msg = "Sunday";
                        break;

                    default:
                        msg = "error";
                        break;

                }
                Console.WriteLine(msg);
            }
        }
    }
}
