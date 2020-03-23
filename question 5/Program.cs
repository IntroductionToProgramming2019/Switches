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

namespace question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowelCount = 0;
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine().ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                switch(word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;

                    default:
                        break;
                }

            }
            Console.WriteLine("There are {0} vowels", vowelCount);
        }
    }
}