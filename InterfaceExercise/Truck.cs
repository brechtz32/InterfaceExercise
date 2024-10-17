using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        //Truck
        public int weightOfTruck { get; set; }

        public bool hasToolBox { get; set; }

        //IVehicle
        public int numberOfPassengers { get; set; }

        public int numberOfDoors { get; set; }

        public bool hasFourWheelDrive { get; set; }

        public bool hasSunRoof { get; set; }

        //ICompany
        public bool isDomestic { get; set; }

        public string companyName { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Let's see, what is the weight of this truck {weightOfTruck}Tons and does it have a tool box ({hasToolBox}). Nice! Your car has {numberOfDoors} doors and can hold {numberOfPassengers} people. Let's see, is your car 4 wheel drive ({hasFourWheelDrive}) and does it have a sun roof ({hasSunRoof}). This car is domestic ({isDomestic}) {companyName}.");
        }
    }
}
