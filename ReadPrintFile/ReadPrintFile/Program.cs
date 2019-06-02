using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPrintFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the file path:");
                string path = Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: The directory doesn't exist.");
            }


            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect file path");
            }

            catch (PathTooLongException)
            {
                Console.WriteLine("The file path or name is too long");
            }

            
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied, insufficient permission. ");
           
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Incorrect format for file path.");
            }

            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
