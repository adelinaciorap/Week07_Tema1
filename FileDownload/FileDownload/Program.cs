using System;
using System.IO;
using System.Net;


namespace FileDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL to donwload from:");
            string url = Console.ReadLine();
            string localDir = Path.GetFileName(url);
            WebClient client1 = new WebClient();

            try
            {
                client1.DownloadFile(url, localDir);
                Console.WriteLine("File was succesfully donwloaded");
                Console.WriteLine("You can access downloaded file in local folder of this program\\bin\\Debug\\");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("The address cannot be null.");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid URL or file name");
            }
            
            
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            finally
            {
                client1.Dispose();
            }
        }
    }
}
