using System;
using System.Collections.Generic;

namespace prototype
{
    abstract class VehiclePrototype
    {
        public abstract VehiclePrototype Clone();
        public string ChassisNumber { get; set; }
    }

    class Cbr650R : VehiclePrototype
    {
        public Cbr650R()
        {
            WarrantyYear = 4;
            Km = 0;
            Weight = 207;
            Engine = 650;
            Year = DateTime.Today.Year;
            Height = 65;
        }
        public int Height { get; set; }
        public int WarrantyYear { get; set; }
        public int Km { get; set; }
        public double Weight { get; set; }
        public int Engine { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public override VehiclePrototype Clone()
        {
            return this.MemberwiseClone() as VehiclePrototype;
        }

    }

    class AfricaTwin : VehiclePrototype
    {
        public AfricaTwin()
        {
            WarrantyYear = 3;
            Km = 0;
            Weight = 245;
            Engine = 1000;
            Year = DateTime.Today.Year;
            Height = 85;
        }
        public int WarrantyYear { get; set; }
        public int Km { get; set; }
        public double Weight { get; set; }
        public double Engine { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int Height { get; set; }
        public override VehiclePrototype Clone()
        {
            return this.MemberwiseClone() as VehiclePrototype;
        }
    }
    class Program
    {        
        /*static void Main(string[] args)
        {
            VehicleList = new List<VehiclePrototype>();
            for (int i = 0; i < 10; i++)
            {
                Cbr650R motor = new Cbr650R();
                motor.WarrantyYear = 4;
                motor.Km = 0;
                motor.Weight = 207;
                motor.Engine = 650;
                motor.Year = DateTime.Today.Year;
                motor.ChassisNumber = i.ToString() + "Cbr650";

                VehicleList.Add(motor);
            }
            for (int i = 0; i < 10; i++)
            {
                AfricaTwin motor = new AfricaTwin();
                motor.WarrantyYear = 3;
                motor.Km = 0;
                motor.Weight = 245;
                motor.Engine = 1000;
                motor.Year = DateTime.Today.Year;
                motor.ChassisNumber = i.ToString() + "AfricaTwin";

                VehicleList.Add(motor);
            }

            foreach (var motor in VehicleList)
            {
                Console.WriteLine("Motor ChassisNumber: " + motor.ChassisNumber);
            }
            Console.ReadLine();
        }*/
        public static List<VehiclePrototype> VehicleList { get; set; }
        static void Main(string[] args)
        {
            VehicleList = new List<VehiclePrototype>();
            for (int i = 0; i < 10; i++)
            {
                var index = VehicleList.FindIndex(f => f.GetType() == typeof(Cbr650R));
                Cbr650R motor = index == -1 ? new Cbr650R() : (Cbr650R)VehicleList[index].Clone();
                if (index == -1)
                {
                    motor.WarrantyYear = 4;
                    motor.Km = 0;
                    motor.Weight = 207;
                    motor.Engine = 650;
                    motor.Height = 65;
                }
                motor.Year = DateTime.Today.Year;
                motor.ChassisNumber = i.ToString() + "Cbr650";

                VehicleList.Add(motor);
            }
            for (int i = 0; i < 10; i++)
            {
                var index2 = VehicleList.FindIndex(f => f.GetType() == typeof(AfricaTwin));
                AfricaTwin motor = index2 == -1 ? new AfricaTwin() : (AfricaTwin)VehicleList[index2].Clone();
                if (index2 == -1)
                {
                    motor.WarrantyYear = 3;
                    motor.Km = 0;
                    motor.Weight = 245;
                    motor.Engine = 1000;
                    motor.Height = 85;
                }
                motor.Year = DateTime.Today.Year;
                motor.ChassisNumber = i.ToString() + "AfricaTwin";

                VehicleList.Add(motor);
            }

            foreach (var motor in VehicleList)
            {
                Console.WriteLine("Motor ChassisNumber: " + motor.ChassisNumber);
            }
            Console.ReadLine();
        }
    }
}