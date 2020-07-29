using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is the string for our example.";

            string partWithOutLength = testString.Substring(10);
            string partWithLength = testString.Substring(5, 10);

            Console.WriteLine($"This is partWithOutLength: {partWithOutLength}");
            Console.WriteLine($"This is partWithLength: {partWithLength}");


            //Get the new sentence
            Console.WriteLine("Enter a new sentence: ");
            string testSentence = Console.ReadLine();

            //Find first blank position
            int firstBlankPosition = testSentence.IndexOf(' ');
            //First word findit with firstBlankPosition
            string withOutFirstWord = testSentence.Remove(0, firstBlankPosition + 1);

            //Last index of " "
            int lastBlankPosition = withOutFirstWord.LastIndexOf(' ');
            string withOutFirstAndLastWord = withOutFirstWord.Remove(lastBlankPosition);

            Console.WriteLine(withOutFirstAndLastWord);

            Console.ReadKey();
        }
    }
}
