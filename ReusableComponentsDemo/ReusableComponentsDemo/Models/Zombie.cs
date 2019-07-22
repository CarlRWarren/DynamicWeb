using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReusableComponentsDemo.Models
{
    public class Zombie
    {
        public string ZedType { get; set; }
        public int NumberOfArms { get; set; }
        public int NumberOfLegs { get; set; }
        public string ImageName { get; set; } = "Walker.jpg";
        public int HoursUndead { get; set; }
        public float StinkRatio { get; set; } = 0.5f;
    }
}
