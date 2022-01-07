using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class Passenger
    {
        protected string name;
        protected string contact;
        protected string passport;
        protected Airplane flight;
        protected string seat;
        protected double cost;

        public Passenger(string name, string contact, string passport, string seat, double cost)
        {
            this.name = name;
            this.contact = contact;
            this.passport = passport;
            this.seat = seat;
            this.cost = cost;
        }

        public Airplane BookFlight
        {
            get { return flight; }
            set { flight = value; }
        }

        public virtual double getcost()
        {
            return this.cost;
        }
        public string getinfo()
        {
            return this.name + "\t" + this.contact + "\t" + this.passport + "\t" + this.flight.FlightID + "\t" + this.seat + "\t" + Convert.ToString(this.getcost());
        }

        
    }


}
