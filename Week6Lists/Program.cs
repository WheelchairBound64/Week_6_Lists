using System.Collections.Generic;
/*
 * Clark Comstock
 * Week 6 Lists and Dictionaries
 * 2/24/2023
 */
namespace Week6Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contains the problem methods, added a bit of flavor text to make the program look cleaner
            Console.WriteLine("Problem #1: ");
            ProblemOne();
            Console.WriteLine("\nProblem #2: ");
            ProblemTwo();
        }

        static void ProblemOne()
        {
            //creates a list and runs a do/while statement to get the names to use for the friends message
            List<string> FaceBook = new List<string>();
            string name = "";
            int count = 0;

            do
            {
                Console.WriteLine("Enter a name or leave the space blank to exit the program: ");
                name = Console.ReadLine();
                FaceBook.Add(name);
            } while (name != "");

            //removes the final count and index from the list, otherwise there would be a blank and 1 extra person added
            foreach (string s in FaceBook)
            {
                count++;
            }
            count = count - 1;
            FaceBook.RemoveAt(count);

            //displays the results, even added an else if for when there are 3 people (so the display message reads '1 other' instead of '1 others'
            if (count == 0)
            {
                Console.WriteLine("You got the whole squad laughin o_o");
            }
            else if (count == 1)
            {
                Console.WriteLine(FaceBook[0] + " liked your post!");
            }
            else  if (count == 2)
            {
                Console.WriteLine(FaceBook[0] + " and " + FaceBook[1] + " liked your post!");
            }
            else if (count == 3)
            {
                count = count - 2;
                Console.WriteLine(FaceBook[0] + ", " + FaceBook[1] + ", and " + count + " other liked your post!");
            }
            else
            {
                count = count - 2;
                Console.WriteLine(FaceBook[0] + ", " + FaceBook[1] + ", and " + count + " others liked your post!");
            }
        }

        static void ProblemTwo()
        {
            //creates the dictionary and gets the sentence from the user. if the user enters nothing, lock them in a while statement until they write a sentence
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            string input = "";

            Console.WriteLine("Please enter a sentence: ");
            input = Console.ReadLine();
            while (input == "")
            {
                Console.WriteLine("You did not enter a sentence, please enter a sentence now: ");
                input = (Console.ReadLine());
            }

            //changes the input to lower case to make the end result cleaner looking
            input = input.ToLower();

            //loops and checks every character in the sentence
            foreach (char c in input)
            {
                char letter;
                int count = 1;

                letter = c;
                //if a character already exists, just adds to the value for that key
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                //if the character doesn't exist, add it to the dictionary and add 1 to the count
                else
                    characterCount.Add(letter, count);
            }

            //displays the results in a clean way
            foreach (KeyValuePair<char, int> pair in characterCount)
            {
                Console.WriteLine("Letter: " + pair.Key + " | Count: " + pair.Value);
            }
        }
    }
}