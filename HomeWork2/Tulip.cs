using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Tulip : Flower
    {
        public Tulip(string name)
        {

        }
        public Tulip(string name, double cost) : base(name, cost)
        {

        }
        public Tulip(string name, double cost, int quantity) : base(name, cost, quantity)
        {
        }
    }
}
