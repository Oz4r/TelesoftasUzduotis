using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TelesoftasUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string retry = "N";
            var lines = new List<string>();
            var FileOutput = new FileOutput();
            string filePath = ".\\var.txt";
            do
            {
                Console.WriteLine("\n1) Use parameters as command line arguments\n");
                Console.WriteLine("2) Use parameters from a .txt file\n");
                Console.WriteLine("3) Exit\n");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\nYou have chosen to enter paramaters from the command line\n");
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("\nPlease enter the text you want to be formatted:\n");
                        string myString = Console.ReadLine();
                        Console.WriteLine("\nPlease enter the maximum length of the text line:\n");
                        int maxLength = Convert.ToInt32(Console.ReadLine());

                        myString.Truncate(maxLength, lines);

                        FileOutput.Output(lines);

                        Console.WriteLine("Your formatted text is in the Project directory, press Enter to quit");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to read data from a .txt file");
                        List<string> variables = File.ReadAllLines(filePath).ToList();
                        //REVALUATE THIS CODE
                        foreach(var line in variables)
                        {
                            string[] entries = line.Split(',');
                            maxLength = Int32.Parse(entries[0]);
                            myString = entries[1];
                            myString.Truncate(maxLength, lines);
                        }
                        FileOutput.Output(lines);
                        Console.WriteLine("Your formatted text is in the Project directory, press Enter to quit");
                        Console.ReadLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Would you like to retry? Y/N");
                        retry = Console.ReadLine().ToUpper();
                        break;
                }
            } while (retry != "N");

        }

    }
}
