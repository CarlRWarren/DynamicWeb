using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameLibraryPt1.Models
{
    public class Game
    {
        public string Title { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public string EsrbRating { get; set; }
        public int ReleaseDate { get; set; }
        public string Image { get; set; }
        public string LoanedTo { get; set; } = null;
        public DateTime LoanDate { get; set; }

    }
}
