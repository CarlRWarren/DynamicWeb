using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsDemo.Models
{
    public class Zombie
    {
        public string Name { get; set; }
        public string ZedType { get; set; }
        public int HoursUndead { get; set; }

        public override string ToString()
        {
            return $"{Name}({ZedType}) - {HoursUndead} hour(s) undead";
        }
    }
}
