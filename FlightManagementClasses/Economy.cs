using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class Economy:Passenger
    {
        private string passenger_type;
        public Economy(string name, string contact, string passport, string seat, double cost) : base(name, contact, passport, seat, cost)
        {
            this.passenger_type = "Economy";
        }

        public string PassengerType
        {
            get { return passenger_type; }
            set { passenger_type = value; }
        }

        public override double getcost()
        {
            return this.cost*1.00;
        }
    }
}
