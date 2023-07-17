using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaneProject.Models
{
    public class Flights
    {
        public string LocationFrom { get; set; }
        public string TimeOfFlight { get; set; }
        public string TimeOfArrival { get; set; }
        public string TypeOfPlane { get; set; }
        public string UniqueNumberOfPlane { get; set; }
        public string NamePilot { get; set; }
        public int CapacityOfPassengers  { get; set; }
        public string CapacityBusinessClass { get; set; }

    }
}