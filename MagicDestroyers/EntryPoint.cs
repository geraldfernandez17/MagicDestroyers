using MagicDestroyers.Characters.Melee;
using System;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            //Console.WriteLine("Hello World!");

            Assassin ass1 = new Assassin();
            Assassin ass2 = new Assassin();
            Assassin ass3 = new Assassin();

            Console.WriteLine(ass1.Name);
            Console.WriteLine(ass2.Name);
            Console.WriteLine(ass3.Name);
        }
    }
}
