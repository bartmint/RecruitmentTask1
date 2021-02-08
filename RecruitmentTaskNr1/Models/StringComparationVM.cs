using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTaskNr1.Models
{
    public class StringComparationVM
    {
        public int LengthDiffrence { get; set; }
        public bool Anagrams { get; set; } = true;
        public List<StringDetailsVM> Comparison { get; set; } = new List<StringDetailsVM>();
    }
}
