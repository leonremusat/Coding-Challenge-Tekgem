using System;
using System.Data.SqlTypes;
using CitySearch;
using CityFinder;
//Coding-Challenge-Tekgem
namespace CityFinder
{
    public class Userinput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The list contains the following cities:");
            string CityName = "";
            int SizeWord;
            List<string> CityList = new List<string>();
            CityList.Add("BANG");
            CityList.Add("BANGALORE");
            CityList.Add("BANGKOK");
            CityList.Add("BENGALURU");
            CityList.Add("BANGUI");

            CityList.ForEach(num => Console.WriteLine(num));
            Console.WriteLine("_______________________________________________");
            if (args == null)
            {
                SizeWord = 0;
            }
            else
            {
                SizeWord = args.Length;
            }
            switch (SizeWord)
            {
                case 0:
                    CityName = AskforWord();
                    break;
                case 1:
                    CityName = args[0];
                    break;


            }

            // Add any function called in Main below:
            Console.WriteLine("The inputed was  " + CityName);
            //
            // Use foor loops to print NextCities and Next Letters by calling the classes within the interfaces
        }
        public static string AskforWord()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            return word;
        }
    }


}


namespace CitySearch
{
    using System.Collections.Generic;

    public interface ICityResult
    {
        ICollection<string> NextLetters { get; set; }

        ICollection<string> NextCities { get; set; }
    }
    public class CityResult : ICityResult // Interface cannot be directly called so a class needs to be created
    {
        // Class Constructor
        public ICollection<string> NextLetters { get; set; } // Method for Nexletter using get (write) and set (read)
        public ICollection<string> NextCities { get; set; } // Method for Nexletter using get (write) and set (read)
        public CityResult()
        {
            NextLetters = new List<String>();
            NextCities = new List<String>();
        }
    }
    public interface ICityFinder
    {
        ICityResult Search(string searchString);
    }
    public class CityFinder : ICityFinder
    {

    }
    public ICityResult Search(string searchString)
    {

        // This class should normalise the input (Lower or Higher)
        // Check the if first characters of each word in CityList match with the user input string
        // If it does append the word to the result NextCities 
        // Append the next character of each word using the lenght of the input, for example BANG (len=4) in BANGALOR the 5th character is A

        // Once the Lists for Nextcities and nextLetters are found create a new funciton to remove letters than appear twice or more

        //return Nextcities and NextLetters under the ICityResult interface

    }
}


// Main CHallenges: Learn C# and understand how interface work with each other, and how to make them callable with a public class

