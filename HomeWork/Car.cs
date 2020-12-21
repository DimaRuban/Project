using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Car
    {
        public string Model { get; set; }

        public int Weight { get; set; }

        public int Power { get; set; }

        public Car()
        {

        }

        public Car(string model, int weight, int power)
        {
            Model = model;
            Weight = weight;
            Power = power;
        }

        public void SetPower(int power)
        {
            Power = power;
        }
        public virtual void ChangeCapacity()
        {
            Console.WriteLine("Capacity = ");
        }
    }
}
