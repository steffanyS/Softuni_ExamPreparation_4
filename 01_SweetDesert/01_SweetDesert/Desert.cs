using System;

namespace _01_SweetDesert
{
    class Desert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            if (guests % 6 != 0)
            {
                guests = ((guests / 6) + 1) * 6;
            }

            var portions = guests / 6;

            var shoppingCart = (2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice) * portions;

            if (cash >= shoppingCart)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {shoppingCart:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {shoppingCart - cash:F2}lv more.");
            }
        }
    }
}
