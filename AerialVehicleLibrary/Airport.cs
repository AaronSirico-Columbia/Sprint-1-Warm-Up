using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialVehicleLibrary
{
    internal class Airport
    {
        public int MaxVehicles;
        public List<AerialVehicle> Vehicles;

        public string AirportCode { get; set; }

        Airport(string Code)
        {
            Code = this.AirportCode;
        }

        Airport(string Code, int MaxVehicles)
        {
            Code = this.AirportCode;
            MaxVehicles = this.MaxVehicles;
        }

        public string AllTakeOff()
        {
            return AirportCode;
        }

        public string Land(AerialVehicle a)
        {
            return $"{a} has landed.0";
        }

        public string Land(List<AerialVehicle> landing)
        {
            foreach(AerialVehicle vehicle in landing)
                {
                return $"{vehicle} Landed";
            }
            return null;

        }

        public string TakeOff(AerialVehicle a)
        {
            return $"{a} has taken off.";
        }
    }

 

}
