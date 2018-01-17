using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> logBook = new List<string>(); // List where all the logs are supposed to be saved

            int convertedChoice = 0;
            while (convertedChoice != 5) // Play menu until choice becomes 5 
            {
                Console.WriteLine("Welcome to your log-book!");
                Console.WriteLine("[1] Write a new log.");
                Console.WriteLine("[2] Show all past logs.");
                Console.WriteLine("[3] Search for log."); // Search with the help of perhaps title?
                Console.WriteLine("[4] Delete all logs.");
                Console.WriteLine("[5] Exit.");
                Console.WriteLine("What would you like to do today?");
                string choice = Console.ReadLine();
                bool result = int.TryParse(choice, out convertedChoice);
                if (result == false) // Play on screen when a invalid choice is typed in 
                {
                    Console.WriteLine("Please type in a valid choise (1,2,3 or 4).");
                    Console.ReadLine(); Console.Clear();
                }

                switch (convertedChoice) // Write new log post 
                {
                    case 1: // Add item 
                        {
                            Console.WriteLine("Type in a title for your log:");
                            string title = Console.ReadLine();
                            DateTime date = DateTime.Now;
                            Console.WriteLine(DateTime.Now);
                            Console.WriteLine("Please, start writing on todays note entry:");
                            string text = Console.ReadLine(); //Can barely write any text....how do i expand?
                            string entry = title + "\t" + date + "\n" + text;
                            logBook.Add(entry);
                        }
                        break;
                    case 2: // Show all logs... // It doesnt work here...it doesnt show any logs at all actually 
                        {
                            Console.WriteLine("All logs:");
                            {
                                for(int c = 0; c < logBook.Count; c++)
                                {
                                    Console.WriteLine(logBook[c]);
                                }
                            }
                            break;
                        }
                    case 3: // Search for a log // Doesnt work as expected 
                        Console.WriteLine("Search for log:");
                        string search = Console.ReadLine().ToLower();

                        bool found = false;
                        for (int i = 0; i < logBook.Count; i++)
                        {
                            if (logBook[i].ToLower().Contains(search))
                            {
                                Console.WriteLine("Log was successfully found!"); // How do I make the found log show underneath this text? 
                                Console.WriteLine(logBook[i]);
                                found = true;
                                break;
                            }
                        }

                        if (found == false)
                        {
                            Console.WriteLine("The log was unfortunatley not found!");
                        }
                        break;

                    case 4: // Delete all logs // Is this the proper way? 
                        logBook.Clear();
                        break;
                }
            }
        }
    }
}




 //SAMPLE switch Statement

 //switch(variableName)
 //{
 //   case 0:
 //   {
 //       break;
 //   }
 //   case 1:
 //   {
 //       break;
 //   }
 //   default:
 //   {
 //       break;
 //   }
 //}
