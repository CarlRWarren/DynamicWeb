using DALDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALDemo.Data
{
    public interface IZombieDAL
    {
        int GetZombieCount();//to try and prevent a greedy fetch for index
        IEnumerable<Zombie> GetAllZombies();
        Zombie GetZombieByIndex(int index);
    }
}
