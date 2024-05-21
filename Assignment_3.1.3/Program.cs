/*
Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/

using System.Threading.Channels;

namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string: ");
            string input = Console.ReadLine(); 
            char targetChar = ' ';
            int charCount = input.Count(c => c == targetChar);
            Console.WriteLine($"\"{input}\" contains {charCount} spaces.");
        }


        
        

    }
}
