using Newtonsoft.Json;
using RecruitmentTaskNr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecruitmentTaskNr1.BL
{
    public class StringComparator: IStringComparator
    {
        public StringComparationVM CompareStrings(string str1, string str2)
        {
            var stringsComparation = new StringComparationVM();
            var firstStringDescription = new StringDetailsVM();
            var secondStringDescription = new StringDetailsVM();

            firstStringDescription.Length = str1.Length;
            firstStringDescription.Value = str1;
            firstStringDescription.LettersTypes = CalculateAmmountOfLetters(str1);
            firstStringDescription.CapitalLetters = CheckWhichLettersAreCapital(str1);
            firstStringDescription.LowerLetters = CheckWhichLettersAreLower(str1);
            firstStringDescription.Vowels = CalculateAmmountOfVowels(str1);
            firstStringDescription.IsPalindrom = IsPalindrom(str1);

            secondStringDescription.Length = str2.Length;
            secondStringDescription.Value = str2;
            secondStringDescription.LettersTypes = CalculateAmmountOfLetters(str2);
            secondStringDescription.CapitalLetters = CheckWhichLettersAreCapital(str2);
            secondStringDescription.LowerLetters = CheckWhichLettersAreLower(str2);
            secondStringDescription.Vowels = CalculateAmmountOfVowels(str2);
            secondStringDescription.IsPalindrom = IsPalindrom(str2);

            stringsComparation.Anagrams = AreStringsAnagrams(str1, str2);
            stringsComparation.LengthDiffrence = CompareLengthOfStrings(str1, str2);

            stringsComparation.Comparison.Add(firstStringDescription);
            stringsComparation.Comparison.Add(secondStringDescription);

            return stringsComparation;
        }
        private int CompareLengthOfStrings(string str1, string str2)
        {
            return Math.Abs(str1.Length - str2.Length);
        }
        private bool AreStringsAnagrams(string str1, string str2)
        {
            var sortedStr1=String.Concat(str1.ToLower().OrderBy(c => c));
            var sortedStr2 = String.Concat(str2.ToLower().OrderBy(c => c));

            var comparation= String.Compare(sortedStr1, sortedStr2);

            if (comparation == 0)
                return true;
            else
                return false;
        }
        private Dictionary<string, int> CalculateAmmountOfLetters(string str1)
        {
            Dictionary<string, int> dic =
                new Dictionary<string, int>
                {
                    {"UpperCharacters", 0 },
                    {"LowerCharacters", 0},
                    {"Numbers", 0    },
                    {"SpecialCharacters", 0 }
                };

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] >= 'A' && str1[i] <= 'Z')
                    dic["UpperCharacters"] += 1;
                else if (str1[i] >= 'a' && str1[i] <= 'z')
                    dic["LowerCharacters"] += 1;
                else if (str1[i] >= '0' && str1[i] <= '9')
                    dic["Numbers"] += 1;
                else
                    dic["SpecialCharacters"] += 1;
            }

            return dic;
        }
        private int CalculateAmmountOfVowels(string str1)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u','y'};
            str1 = str1.ToLower();

            int ammount = 0;

            foreach(var letter in str1)
            {
                foreach(var vowel in vowels)
                {
                    if (letter == vowel)
                        ammount++;
                }
            }
            return ammount;
        }
        private List<int> CheckWhichLettersAreCapital(string str1)
        {
            List<int> indexes = new List<int>();
            var convertedString = 0; ;

            for (int i = 0; i < str1.Length; i++)
            {
                
                try
                {
                    convertedString = Convert.ToInt32(str1[i]);

                }
                catch (Exception ex)
                {
                    convertedString = -1;
                    Console.WriteLine(ex);
                }

                if (convertedString > 64 && convertedString < 91)
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }
        private List<int> CheckWhichLettersAreLower(string str1)
        {
            List<int> indexes = new List<int>();
            var convertedString = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                try
                {
                    convertedString = Convert.ToInt32(str1[i]);
                }
                catch (Exception ex)
                {
                    convertedString = -1;
                    Console.WriteLine(ex);
                }

                if (convertedString > 96 && convertedString < 123)
                {
                    indexes.Add(i);
                }
               
            }
            return indexes;
        }
        private bool IsPalindrom(string str1)
        {
            var strLen = str1.Length;
            str1 = str1.ToLower();

            int index = 0;
            for (int i = strLen - 1; i >= 0; i--)
            {
                if (str1[i] != str1[index])
                    return false;
                index++;
            }
            return true;
        }
        //private (string character, int ammount) FindTheMostCommonCharacter(string str1)
        //{
        //    Dictionary<string, int> characters = new Dictionary<string, int>();

        //    foreach (var letter in str1)
        //    {
        //        var character = letter.ToString();
        //        if (characters.ContainsKey(character))
        //        {
        //            characters[character] += 1;
        //            continue;
        //        }
        //        characters.Add(character, 1);
        //    }

        //    List<int> test = new List<int>();
        //    List<string> keys = new List<string>();
        //    int initial = characters[str1.First().ToString()];
        //    foreach (var item in characters)
        //    {
        //        var val = item.Value;
        //        if (initial >= val)
        //        {
        //            initial = val;
        //            keys.Add(item.Key);
        //        }

        //    }
        //}
    }
    
}
