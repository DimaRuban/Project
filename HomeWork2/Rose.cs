using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Rose : Flower
    {
        public Rose(string name)
        {

        }
        public Rose(string name, double cost) : base(name, cost)
        {

        }
        public Rose(string name, double cost, int quantity) : base(name, cost, quantity)
        {
        }
    }
}
