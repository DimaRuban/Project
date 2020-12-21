using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower();
            Rose rose = new Rose("Роза", 20);
            Pion pion = new Pion("Пион", 30);
            Lily lily = new Lily("Лиллия", 25);
            Tulip tulip = new Tulip("Тюльпан", 17);
            Chrysanthemum chrysanthemum = new Chrysanthemum("Хризантема", 20);


            Console.WriteLine("Введите количество роз в букете: ");
            rose.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество пионов в букете: ");
            pion.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество лилий в букете: ");
            lily.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество тюльпанов в букете: ");
            tulip.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество хризантем в букете: ");
            chrysanthemum.Quantity = int.Parse(Console.ReadLine());


            double roses = rose.CostFlowers(rose.Cost, rose.Quantity);
            double pions = pion.CostFlowers(pion.Cost, pion.Quantity);
            double lilys = lily.CostFlowers(lily.Cost, lily.Quantity);
            double tulips = tulip.CostFlowers(tulip.Cost, tulip.Quantity);
            double chrysanthemums = chrysanthemum.CostFlowers(chrysanthemum.Cost, chrysanthemum.Quantity);

            double bouqetCost = flower.CostBouqet(roses, pions, lilys, tulips, chrysanthemums);
            double bouqetQuantity = flower.CounterBouqetQuantity(rose.Quantity, pion.Quantity, lily.Quantity, tulip.Quantity, chrysanthemum.Quantity);

            Console.WriteLine($"Стоимость букета = {bouqetCost}");
            Console.WriteLine($"Количество цветов в букете = {bouqetQuantity}");

            Console.ReadKey();
        }
    }
}
