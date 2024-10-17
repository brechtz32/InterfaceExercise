using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle:

            /* DONE - Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //DONE - In ICompany: 

            /* DONE - Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //DONE - In each of your Car, Truck, and SUV classes

            /* DONE - Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //DONE - Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var chevyCamero = new Car();
            chevyCamero.isSportsCar = true;
            chevyCamero.isManualTransmission = true;
            chevyCamero.numberOfPassengers = 2;
            chevyCamero.numberOfDoors = 2;
            chevyCamero.hasFourWheelDrive = false;
            chevyCamero.hasSunRoof = false;
            chevyCamero.isDomestic = true;
            chevyCamero.companyName = "Chevrolet";

            var toyotaTundra = new Truck();
            toyotaTundra.companyName = "Toyota";
            toyotaTundra.numberOfPassengers = 5;
            toyotaTundra.weightOfTruck = 4000;
            toyotaTundra.numberOfDoors = 4;
            toyotaTundra.hasFourWheelDrive = true;
            toyotaTundra.hasToolBox = true;
            toyotaTundra.isDomestic = false;
            toyotaTundra.hasSunRoof = false;

            var hondaOdyssey = new SUV { hasSlidingDoors = true, isSoccerMomCar = true, numberOfPassengers = 27, numberOfDoors = 4, hasFourWheelDrive = false, hasSunRoof = true, isDomestic = false, companyName = "Honda" };
                        

            Console.WriteLine("----------------------");
            chevyCamero.DisplayDetails();
            Console.WriteLine("----------------------");
            toyotaTundra.DisplayDetails();
            Console.WriteLine("----------------------");
            hondaOdyssey.DisplayDetails();
            Console.WriteLine("----------------------");
            //Console.WriteLine(IVehicle.DisplayDetails(toyotaTundra));
            //Console.WriteLine(IVehicle.DisplayDetails(hondaOdyssey));

            //Option for displaying values: 
            //DONE - Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //DONE - Implement the stubbed out method in the derived classes.
            //DONE - In the scope of the method, use string interpolation to display property values.
            //???In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
