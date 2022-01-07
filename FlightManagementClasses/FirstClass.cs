using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class FirstClass:Passenger
    {
        private string passenger_type;
        public FirstClass(string name, string contact, string passport, string seat, double cost) : base(name, contact, passport, seat, cost)
        {
            this.passenger_type = "First Class";
        }

        public string PassengerType
        {
            get { return passenger_type; }
            set { passenger_type = value; }
        }

        public override double getcost()
        {
            return this.cost * 2.50;
        }
    }
}
