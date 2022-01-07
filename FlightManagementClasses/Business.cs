using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class Business:Passenger
    {
        private string passenger_type;
        public Business(string name, string contact, string passport, string seat, double cost) : base(name, contact, passport, seat, cost)
        {
            this.passenger_type = "Business";
        }

        public string PassengerType
        {
            get { return passenger_type; }
            set { passenger_type = value; }
        }

        public override double getcost()
        {
            return this.cost * 5.00;
        }

    }
}
