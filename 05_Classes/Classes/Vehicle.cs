﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Airplane, Boat, Segway}
    public class Vehicle
    {
        // 1 - Access modifier
        // 2 - Type
        // 3 - Name (PascalCaseTyped)
        // 4 - Getters and Setters

        // 1    2       3       4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; } = 0;
        public VehicleType Type { get; set; }
        public Indicator LeftBlinker { get; set; }
        public Indicator RightBlinker { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle(string make, string model, VehicleType type)
        {
            Make = make;
            Model = model;
            Type = type;
        }

        // Method (class method or instance method)

        // 1 - Access Modifer
        // 2 - Return Type
        // 3 - Method Signature
        //  a - Name
        //  b - Parameters
        // 4 - Body (the part that runs)
        
        //1     2       3a  3b
        public void TurnOn()
        //4
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turn the vehicle off");
        }

        public void IndicateRight()
        {
            RightBlinker.TurnOn();
            LeftBlinker.TurnOff();
        }
        public void IndicateLeft()
        {
            RightBlinker.TurnOff();
            LeftBlinker.TurnOn();
        }
        public void Hazards()
        {
            RightBlinker.TurnOn();
            LeftBlinker.TurnOn();
        }
        public void ClearIndicators()
        {
            RightBlinker.TurnOff();
            LeftBlinker.TurnOff();
        }
    }

    public class Indicator
    {
        public bool IsBlinking { get; private set; }

        public void TurnOn()
        {
            IsBlinking = true;
        }
        public void TurnOff()
        {
            IsBlinking = false;
        }
    }
    // classes = noun ; properties = adjectives : method = verbs
}
