using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotin_Rajapinta
{
    public class Robotti : IRobottiKäsky
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool OnKäynnissä { get; set; }
        public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

        public void Suorita(Robotti robotti)
        {
            Console.WriteLine("");
            foreach (IRobottiKäsky? käsky in Käskyt)
            {
                käsky?.Suorita(robotti);
                Console.WriteLine($"Robotti: [{X} {Y} {OnKäynnissä}]");
            }
        }
    }
}
