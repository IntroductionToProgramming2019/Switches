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

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string code;
            double cost;
            string another;

            bool isValid = true;

            string answer;

            double total = 0;

            do
            {
                do
                {


                    do
                    {
                        isValid = true;
                        Console.WriteLine("Please enter a product code: ");
                        code = Console.ReadLine().ToUpper();
                        switch (code)
                        {
                            case "ASD":
                                cost = 67.95;
                                break;

                            case "THF":
                                cost = 68.90;
                                break;

                            case "TYG":
                                cost = 34.95;
                                break;

                            case "GHT":
                                cost = 88.90;
                                break;

                            case "YUR":
                                cost = 23.80;
                                break;

                            case "UIT":
                                cost = 9.90;
                                break;
                            case "HIT":
                            case "UIP":
                            case "RRT":
                            case "JJK":
                            case "IOP":
                                cost = 10;
                                break;

                            default:
                                string msg = "error code, try again.";
                                Console.WriteLine(msg, ": ");
                                isValid = false;
                                cost = 0;
                                break;
                        }

                    } while (isValid == false);


                    total = total + cost;
                    if (total > 500)
                    {
                        total = total - (total * .10);
                    }
                    Console.WriteLine("Your total is {0:C}", total);


                    Console.WriteLine("Do you wish to continue? Type y if yes : ");

                    answer = Console.ReadLine().ToLower();

                }
                while (answer == "y");

                Console.WriteLine("Thank you");
                Console.WriteLine("Do you wish to process another customer? Type y if yes:");
                another = Console.ReadLine().ToLower();

            } while (another == "y");
            Console.WriteLine("Goodbye");
        }
    }
}




