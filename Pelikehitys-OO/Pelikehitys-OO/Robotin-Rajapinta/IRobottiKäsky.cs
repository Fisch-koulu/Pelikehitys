
namespace Robotin_Rajapinta
{
    public interface IRobottiKäsky
    {
        void Suorita(Robotti robotti);
    }

    //ylös
    public class YlosKasky : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.Y++;
        }
    }

    //alas
    internal class AlasKasky : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.Y--;
        }
    }
    
    //oikea
    internal class OikeaKasky : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.X++;
        }
    }

    //vase
    internal class VasenKasky : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == false) return;
            robotti.X--;
        }
    }

    //käynnistää robotin
    internal class Kaynnista : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = true;
        }
    }

    //samuttaa robotin
    internal class Sammuta : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = false;
        }
    }
}
