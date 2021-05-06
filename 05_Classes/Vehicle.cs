using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType {Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle =typeOfVehicle;
        }
        public Vehicle() { }

        //1 access modifier
        //2 Type - type the property holds
        //3 NAme
        //4 Getters and Setters

        //1      2     3          4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType  TypeOfVehicle { get; set;}

        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }
        
        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
            //LeftIndicator.TurnOn
        }

        //Challenge
        // Make indicator its own custom class
        //properties including IsFlashing
        // Method for TurnOn() and TurnOff
        // - methods would set value of IsFlashing
    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void Turnoff()
        {
            IsFlashing = false;
        }
    }
}
