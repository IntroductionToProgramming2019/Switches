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

namespace question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i = i + 10)
            {
                int celsius = i;
                int fahrenheit = 9 / 5 * (celsius + 32);
                Console.WriteLine("{0}, {1}", i, fahrenheit );
            }
        }
    }
}
