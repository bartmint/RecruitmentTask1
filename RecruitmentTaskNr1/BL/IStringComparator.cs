using RecruitmentTaskNr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTaskNr1.BL
{
    public interface IStringComparator
    {
        StringComparationVM CompareStrings(string str1, string str2);
    }
}
