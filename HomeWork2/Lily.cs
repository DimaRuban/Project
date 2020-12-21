using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Lily : Flower
    {
        public Lily(string name)
        {

        }
        public Lily(string name, double cost) : base(name, cost)
        {

        }
        public Lily(string name, double cost, int quantity) : base(name, cost, quantity)
        {
        }
    }
}
