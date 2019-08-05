using DALDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALDemo.Data
{
    public class CLoneZombieDB : IZombieDAL
    {
        //typically in a DAL would have add
        private static List<Zombie> zeds = new List<Zombie>()
        {
            new Zombie() {ZedType="Walker", NumberOfArms=2, NumberOfLegs=2},
            new Zombie() {ZedType="Runner", NumberOfArms=1, NumberOfLegs=1},
            new Zombie() {ZedType="Crawl", NumberOfArms=2, NumberOfLegs=0},
            new Zombie() {ZedType="Pirate", NumberOfArms=2, NumberOfLegs=1, ImageName="Pirate.jpg"}
        };

        public IEnumerable<Zombie> GetAllZombies()
        {
            return zeds;
        }

        public Zombie GetZombieByIndex(int index)
        {
            return zeds[index];
        }

        public int GetZombieCount()
        {
            return zeds.Count;
        }
    }
}
