using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set;}

        public Vehicle()
        {

        }
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicatorRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
        public void IndicatorLeft()
        {
            LeftIndicator.TurnOff();
            RightIndicator.TurnOn();
        }

        public void TurnOnHazards()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOn();
        }
        public void TurnHazardsOff()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOff();
        }

    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }
        
        public void TurnOn()
        {
            IsFlashing = true;
            Console.WriteLine("Your indicator is on.");
        }
        public void TurnOff()
        {
            IsFlashing = false;
            Console.WriteLine("Your indicator is off.");
        }


    }
}
