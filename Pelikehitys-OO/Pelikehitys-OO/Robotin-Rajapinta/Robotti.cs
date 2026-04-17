using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotin_Rajapinta
{
    public class Robotti
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool OnKäynnissä { get; set; }
        public RobottiKäsky?[] Käskyt { get; } = new RobottiKäsky?[3];

        public void Suorita()
        {
            Console.WriteLine("");
            foreach (RobottiKäsky? käsky in Käskyt)
            {
                käsky?.Suorita(this);
                Console.WriteLine($"Robotti: [{X} {Y} {OnKäynnissä}]");
            }
        }
    }
}
