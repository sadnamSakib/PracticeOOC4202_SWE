using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class Airplane
    {
        private string flightName;
        private string flightid;
        private string airlines;
        private DateTime arrival;
        private DateTime departure;
        private string start;
        private string end;
        private int seat;
        private int totalSeat;
        private List<Passenger> passengerList = new List<Passenger>();

        public Airplane(string flightname, string flightid,string airlines, DateTime arrival, DateTime departure,string start,string end,int totalSeat)
        {
            this.flightName = flightname;
            this.flightid = flightid;
            this.airlines = airlines;
            this.arrival = arrival;
            this.departure = departure;
            this.start = start;
            this.end = end;
            this.totalSeat = totalSeat;
        }

        public bool addPassenger(Passenger passenger)
        {
            
            this.passengerList.Add(passenger);
            this.seat = this.passengerList.Count();
            if (this.seat > this.totalSeat)
            {
                this.passengerList.RemoveAt(this.passengerList.Count() - 1);
                return true;
            }
            {
                return false;
            }
        }

        public string FlightID
        {
            get { return flightid; }
            set { flightid = value; }
        }

        public DateTime ArrivalTime
        {
            get { return arrival; }
            set { arrival = value; }
        }

        public DateTime DepartureTime
        {
            get { return departure; }
            set { departure = value; }
        }

        public string getDestination()
        {
            return this.start + " to " + this.end;
        }


    }
}
