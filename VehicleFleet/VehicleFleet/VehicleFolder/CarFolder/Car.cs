using VehicleFleet.DriverFolder;

namespace VehicleFleet.VehicleFolder.CarFolder
{
    abstract class Car : Vehicle
    {
        private int speed;
        private int amoutOfDrivers = 2;
        private Driver secondDriver;

        protected Car(int id, string brand, string color, int speed) : base(id, brand, color)
        {
            this.Speed = speed;
        }

        public int Speed { get => speed; set => speed = value; }
        internal Driver SecondDriver { get => secondDriver; set => secondDriver = value; }

        public override string GetDrivers()
        {
            return base.GetDrivers() + "\nDriver 2: " + this.SecondDriver.ToString();
        }
    }
}
