using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Detection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a String");
                string inputText = Console.ReadLine();
                int totalNumberOfVowels = HuntingForVowels(inputText);
                Console.WriteLine(totalNumberOfVowels);
            }
        }
        public static int HuntingForVowels(string textUserEnters)
        {
            int numberOfVowels = 0;

            //going thru the list finding and counting vowels
            for (int i = 0; i < textUserEnters.Length; i++)
            {
                char blah = textUserEnters[i];

                //comparing the letters
                if (blah == 'a')
                {
                    numberOfVowels++;
                }
                else if (blah == 'e')
                {
                    numberOfVowels++;
                }
                else if (blah == 'i')
                {
                    numberOfVowels++;
                }
                else if (blah == 'o')
                {
                    numberOfVowels++;
                }
                else if (blah == 'u')
                {
                    numberOfVowels++;
                }

            }

            return numberOfVowels;
        }

    }
}

