using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int min;
            int max;
            int skip = 0;
            int k = 0;
            int skips = 0;
            int number;
            char decider;
            bool wrong = true;
            bool wrongAgain = true;
            bool hasRun = false;
            bool hasRunMore = false;
            bool secondHasRun = false;
            bool secondHasRunMore = false;

            Console.WriteLine("How many numbers do you want to generate? ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1)
            {
                Console.WriteLine("Why fork you, why'd you use a number generator if you don't want to create any numbers?");
                Thread.Sleep(4000);
                Environment.Exit(0);
            }

            Console.WriteLine("Write the minimum number: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the maximum number: ");
            max = Convert.ToInt32(Console.ReadLine());

            while (wrong)
            {
                if (hasRun == true)
                {
                    Console.WriteLine("Now stupid.. tell me do you want to skip a number? And remember Y: yes / N: no");
                }
                else if (hasRunMore == true)
                {
                    Console.WriteLine("welp... didn't know that you were that stupid... i belive you know the question by now.." +
                        " And remember Y: yes / N: no");
                }
                else
                {
                    Console.WriteLine("Do you want to skip a number?  Y: yes / N: no");
                }
                decider = Convert.ToChar(Console.ReadLine());

                if (decider == 'Y' || decider == 'y')
                {
                    Console.WriteLine("great.. extra work..");
                    while (wrongAgain)
                    {
                        k = 0;
                        if (secondHasRun == true)
                        {
                            Console.WriteLine("say no, say no, say no.. Okay you get a do over, skip multiple numbers or no? Y: yes N: no");
                        }
                        else if (secondHasRunMore == true)
                        {
                            Console.WriteLine("You should know the question.. Y: yes N: no");
                        }
                        else
                        {
                            Console.WriteLine("So tell me, will i be lucky or do you want to skip multiple numbers?" +
                           " We're working with the same system as before btw.. so Y: yes and N: no");
                        }
                        decider = Convert.ToChar(Console.ReadLine());
                        if (decider == 'Y' || decider == 'y')
                        {
                            Console.WriteLine("God dammit, i hate you! \r\n " +
                            "Well then, bevare this might be a long journey");

                            skips = Convert.ToInt32(Console.ReadLine());
                            wrongAgain = false;
                        }
                        else if (decider == 'N' || decider == 'n')
                        {
                            Console.WriteLine("Well then.. I'll need to know the number you'd like to skip, " +
                            "remember to choose in the range of minimum and maximum.");
                            skip = Convert.ToInt32(Console.ReadLine());
                            wrongAgain = false;
                        }
                        else
                        {
                            k++;
                            if (hasRun == true)
                            {
                                Console.WriteLine("Okay, i'm not sure whether or not you are completely stupid but erh... We'll try again");
                                k++;
                            }
                            else if (hasRunMore == true)
                            {
                                Console.WriteLine("Okay i'm sure of it now, ya stupid! you can do this..");
                                k++;
                            }
                            else
                            {
                                Console.WriteLine("you've been through this before, and yet you've failed.. I am so disapointed in you.");
                                k++;
                            }

                            if (k <= 3)
                            {
                                secondHasRun = true;
                            }
                            else
                            {
                                secondHasRun = false;
                                secondHasRunMore = true;
                            }
                        }
                        
                    }
                    wrong = false;
                }
                else if (decider == 'N' || decider == 'n')
                {
                    Console.WriteLine("No? Great! no extra work.");
                    wrong = false;
                }
                else
                {
                    Console.WriteLine("Well this is awkward... for you.. You wrote " + decider + " You needed to write Y for yes or N for no..");
                    k++;
                    if (k <= 3)
                    {
                        hasRun = true;
                        k++;
                    }
                    else
                    {
                        hasRun = false;
                        hasRunMore = true;
                    }
                }
            }
            
            if (number == 1)
            {
                Console.WriteLine("The random number is: ");
            }
            else
            {
                Console.WriteLine("The random numbers are: \r\n"); 
            }

            for (int numbr = 1; numbr <= number; numbr++)
            {
                int gen = num.Next(min, max + 1);
                
                while (gen == skip)
                {
                    gen = num.Next(min, max + 1);
                }
                    
                    Console.WriteLine("\t" + gen);
                
            }

            Console.ReadLine();
        }
    }
}
