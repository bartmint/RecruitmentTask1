using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTaskNr1.Models
{
    public class StringDetailsVM
    {
        public int Length { get; set; }
        public string Value { get; set; }
        public Dictionary<string,int> LettersTypes { get; set; }
        public int Vowels { get; set; }
        public List<int> CapitalLetters { get; set; } = new List<int>();
        public List<int> LowerLetters { get; set; } = new List<int>();
        public Dictionary<string, int> TheMostCommonCharacters { get; set; } = new Dictionary<string, int>();
        public bool IsPalindrom { get; set; }
    }
}
