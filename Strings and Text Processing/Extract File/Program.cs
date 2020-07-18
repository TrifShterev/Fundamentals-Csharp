using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndexOf = input.LastIndexOf('\\');
            var fileSubstring = input.Substring(startIndexOf+1);

            var fileAndExtentionArray = fileSubstring.Split('.');

            Console.WriteLine($"File name: {fileAndExtentionArray[0]} \nFile extension: {fileAndExtentionArray[1]}");
        }
    }
}
