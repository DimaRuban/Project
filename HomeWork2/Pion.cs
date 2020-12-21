using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Pion : Flower
    {
        public Pion(string name)
        {

        }
        public Pion(string name, double cost) : base(name, cost)
        {

        }
        public Pion(string name, double cost, int quantity) : base(name, cost, quantity)
        {
        }
    }
}
