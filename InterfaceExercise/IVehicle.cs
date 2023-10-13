using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int Year { get; set; }
        public string Engine {  get; set; }
        public string FuelType { get; set; }

    }
}
