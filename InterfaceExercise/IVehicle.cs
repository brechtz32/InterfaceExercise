using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int numberOfPassengers { get; set; }

        public int numberOfDoors { get; set; }

        public bool hasFourWheelDrive { get; set; }

        public bool hasSunRoof { get; set; }

        public void DisplayDetails();
    }
}
