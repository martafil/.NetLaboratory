using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsProject.Compute
{
    public class WordManipulationOperations
    {
        public static bool IsPalimdorme(string word)
        {
            var reversed_word = word.ToCharArray();
            Array.Reverse(reversed_word);
            return word.CompareTo(new string(reversed_word)) == 0;
        }
    }
}