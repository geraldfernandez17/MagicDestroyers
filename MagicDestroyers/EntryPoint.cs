using MagicDestroyers.Characters.Melee;
using System;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Assassin ass1 = new Assassin();
            Assassin ass2 = new Assassin();
            Assassin ass3 = new Assassin();
            Knight knight1 = new Knight();

            Console.WriteLine(ass1.Name);
            Console.WriteLine(ass2.Name);
            Console.WriteLine(ass3.Name);
            Console.WriteLine(knight1.Name);

            try
            {
                knight1.HealthPoints = 130;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
