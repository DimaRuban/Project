using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 2000, 250);
            Lorry lorry = new Lorry("Man", 7000, 700, 20000);

            car.SetPower(270);
            lorry.ChangeCapacity();

            Console.WriteLine($"Model = {car.Model}, Weight = {car.Weight}, Power = {car.Power}");
            Console.WriteLine($"Model = {lorry.Model}, weight = {lorry.Weight}, power = {lorry.Power}, capacity = {lorry.Capacity}");

            Console.ReadKey();
        }
    }
}
