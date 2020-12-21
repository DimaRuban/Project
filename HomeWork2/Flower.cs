using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Flower
    {
        public Flower()
        {

        }
        public string Name { get; set; }

        public double Cost { get; set; }

        public int Quantity { get; set; }

        public Flower(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public Flower(string name, double cost, int quantity)
        {
            Name = name;
            Cost = cost;
            Quantity = quantity;
        }

        public double CostFlowers(double cost, int quantity)
        {
            return cost * quantity;
        }

        public double CostBouqet(double roses, double pions, double lilys, double tulips, double chrysantemums)
        {
            return roses + pions + lilys + tulips + chrysantemums;
        }

        public int CounterBouqetQuantity(int roses, int pions, int lilys, int tulips, int chrysantemums)
        {
            return roses + pions + lilys + tulips + chrysantemums;
        }
    }
}
