using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementClasses
{
    public class Airport
    {
        public List<Airplane> airplaneList = new List<Airplane>();
        


        public void addPlane(Airplane airplane)
        {
            airplaneList.Add(airplane);
        }

        public string addPassenger(Economy passenger,string flightid)
        {
            foreach(Airplane plane in airplaneList)
            {
                if (plane.FlightID == flightid)
                {
                    if (plane.addPassenger(passenger))
                    {
                        return "Seat Not Available";
                    }
                    else
                    {
                        passenger.BookFlight = plane;
                        return "Seat Booked";
                    }

                }
            }
            return "Airplane Not Found";
        }

        public string addPassenger(Business passenger, string flightid)
        {
            foreach (Airplane plane in airplaneList)
            {
                if (plane.FlightID == flightid)
                {
                    if (plane.addPassenger(passenger))
                    {
                        return "Seat Not Available";
                    }
                    else
                    {
                        return "Seat Booked";
                    }

                }
            }
            return "Airplane Not Found";
        }

        public string addPassenger(FirstClass passenger, string flightid)
        {
            foreach (Airplane plane in airplaneList)
            {
                if (plane.FlightID == flightid)
                {
                    if (plane.addPassenger(passenger))
                    {
                        return "Seat Not Available";
                    }
                    else
                    {
                        return "Seat Booked";
                    }

                }
            }
            return "Airplane Not Found";
        }





    }
}
