
namespace Robotin_Rajapinta
{
    public abstract class RobottiKäsky
    {
        public abstract void Suorita(Robotti robotti);
    }

    //ylös
    public class YlosKasky : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.Y++;
        }
    }

    //alas
    internal class AlasKasky : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.Y--;
        }
    }
    
    //oikea
    internal class OikeaKasky : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.X++;
        }
    }

    //vase
    internal class VasenKasky : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.X--;
        }
    }

    //käynnistää robotin
    internal class Kaynnista : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = true;
        }
    }

    //samuttaa robotin
    internal class Sammuta : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = false;
        }
    }
}
