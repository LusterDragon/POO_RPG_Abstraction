using System;
using AbstraindoRPGcomPOO.src.Entities;

namespace AbstraindoRPGcomPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Patolino",99,"Black Wizard",750,5000);
            Wizard whiteWizard = new Wizard("Jexica", 28, "White Wizard", 185, 100);
            Knight knight = new Knight("Arus", 22, "Knight", 150, 25);
            Ninja ninja = new Ninja("Wedge", 25, "Ninja", 178, 30);


            Console.WriteLine(wizard);
            Console.WriteLine(whiteWizard);
            Console.WriteLine(knight);
            Console.WriteLine(ninja);

            Console.WriteLine(wizard.Ataque(999999999));
            Console.WriteLine(knight.Ataque(1));
            Console.WriteLine(ninja.Ataque());
            Console.WriteLine(whiteWizard.Ataque());
            Console.Read();
        }
    }
}
