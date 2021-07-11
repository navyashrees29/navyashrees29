using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppProgram
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE = 10, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            try
            {
                Options _choice = (Options)Int32.Parse(Console.ReadLine());


                if (_choice != Options.BASIC && _choice != Options.INTERMEDIATE && _choice != Options.ADVANCED)
                {
                    Console.WriteLine("Please enter valid number");

                }
                else
                {

                    switch (_choice)
                    {

                        case Options.BASIC:
                            Console.WriteLine("Basic Level");
                            break;
                        case Options.INTERMEDIATE:
                            Console.WriteLine("Intermediate Level");
                            break;
                        case Options.ADVANCED:
                            Console.WriteLine("Advanced Level");
                            break;
                        default:
                            for (int i = 0; i <= 2; i++)
                            {

                            }
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("enter int value");
            }

            }
           

        }
    }

