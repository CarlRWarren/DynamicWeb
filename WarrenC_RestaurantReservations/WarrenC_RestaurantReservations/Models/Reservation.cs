using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarrenC_RestaurantReservations.Models
{
    public class Reservation
    {
        public DateTime ReservationTime { get; set; }
        public string Name { get; set; }
        public int PartySize { get; set; }
        public string Smoking { get; set; }
        public string SpecialInstructions { get; set; }
        public string ContactNumber { get; set; }
        public string OkToText { get; set; }

        private string smokers;
        private string textable;

        public override string ToString()
        {
            smokers = Smoking=="1" ? "with smoking" : "without smoking";
            textable = OkToText=="1" ? "is textable" : "isn't textable";
            return $"{Name}: {ReservationTime}. Party of {PartySize} {smokers}. SpecialInstructions:{SpecialInstructions}. ContactNumber:{ContactNumber} {textable}.";
        }

    }
}
