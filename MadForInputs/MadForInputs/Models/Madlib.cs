using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadForInputs.Models
{
    public class Madlib
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }
        public string Word3 { get; set; }
        public string Word4 { get; set; }
        public string Word5 { get; set; }

        public List<string> MadlibToList()
        {
            return new List<string>() { Word1, Word2, Word3, Word4, Word5 };
        }
    }
}
