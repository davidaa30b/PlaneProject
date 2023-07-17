using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaneProject.Models
{
    public class Reservations
    {
        public string PersonalName { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
        public int EGN { get; set; }
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string TypeOfTicket { get; set; }
    }
}