using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Chrysanthemum : Flower
    {
        public Chrysanthemum(string name)
        {

        }
        public Chrysanthemum(string name, double cost) : base(name, cost)
        {

        }
        public Chrysanthemum(string name, double cost, int quantity) : base(name, cost, quantity)
        {
        }
    }
}
