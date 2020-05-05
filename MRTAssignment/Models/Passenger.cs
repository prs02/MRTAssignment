using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MRTAssignment.Models
{
    public class Passenger
    {
    }

    public class PassengerModel
    {
        public String idCard { get; set; }
        public String passportNo { get; set; }
        public String name { get; set; }
        public String email { get; set; }

        public double ticketPrice { get; set; }
        public int ticketQty { get; set; }
        public String ticketType { get; set; }
        public String passengerType { get; set; }

        public String stationFrom { get; set; }
        public String stationTo { get; set; }
    }
}