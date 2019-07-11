using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsDemo.Models
{
    public class Movie
    {
        public string Title { get; set; } = "Title Unkown";
        //allowed to change the accessors of get and set seperately
        public int Year { get; set; } = 1888;
        //? after value type allows nullable
        //null pointer is on heap and not empty it's the zero address
        public float StarRating { get; set; } = 0f;
    }
}
