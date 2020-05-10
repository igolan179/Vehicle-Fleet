using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFleet.DriverFolder;

namespace VehicleFleet.VehicleFolder.CarFolder
{
    sealed class Truck : Car
    {

        public Truck(int id, string brand, string color, int speed) : base(id, brand, color, speed)
        {
        }
        public override string GetDrivers()
        {
            return base.GetDrivers();
        }
        public override string GetVehicleType()
        {
            return base.GetVehicleType() + "Truck";
        }
        public override string ToString()
        {
            if (this.SecondDriver is Driver)
            {
                return base.ToString() + "\nDriver: " + this.SecondDriver.ToString();
            }
            else return base.ToString();
        }
    }
}
