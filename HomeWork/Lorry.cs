using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Lorry : Car
    {
        public int Capacity { get; set; }
        public Lorry(string model, int weight, int power, int capacity) : base(model, weight, power)
        {
            Capacity = capacity;
        }

        public override void ChangeCapacity()
        {
            Console.WriteLine("Enter capacity");
            Capacity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
