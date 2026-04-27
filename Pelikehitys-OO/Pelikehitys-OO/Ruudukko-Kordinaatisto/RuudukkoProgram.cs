namespace Ruudukko_Kordinaatisto
{
    internal class RuudukkoProgram
    {
        static void Main(string[] args)
        {
            Koordinaatti yksi = new Koordinaatti(0,0);
            Koordinaatti kaksi = new Koordinaatti(-1,0);
            Koordinaatti kolme = new Koordinaatti(1,0);

            yksi.Tarkistus(kaksi);
            yksi.Tarkistus(kolme);
        }
    }

    public struct Koordinaatti
    {
        private int x;
        private int y;

        public int X { get { return x; } private set { x = value; } }
        public int Y { get { return y; } private set { y = value; } }

        public Koordinaatti(int x, int y) 
        { 
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{x},{y}";
        }

        //tarkistaa onko koordinaatit vieressä, ja palauttaa true/false
        public bool Tarkistus(Koordinaatti og)
        {
            //ensin tarkistaa onko koordinaatti sama
            if (this.x == og.x && this.y == og.y) 
            {
                Console.WriteLine($"Anettu koordinaatti {this.ToString()} on koordinaatissa {og.ToString()}.");
                return true;
            }
            //sitten katsoo onko x 1 isompi tai pienempi välissä
            else if (this.x <= og.x + 1 && this.x >= og.x -1)
            {
                if (this.y <= og.y + 1 && this.y >= og.y - 1)
                {
                    //sitten katsoo onko y 1 isompi tai pienempi välissä
                    Console.WriteLine($"Anettu koordinaatti {this.ToString()} on koordinaatin {og.ToString()} vieressä.");
                    return true;
                }
                //tulemme vain tähän jos, jos y ei ei ole 1 isompi tai pienempi välissä
                Console.WriteLine($"Anettu koordinaatti {this.ToString()} ei ole koordinaatin {og.ToString()} vieressä.");
                return false;
            }
            Console.WriteLine($"Anettu koordinaatti {this.ToString()} ei ole koordinaatin {og.ToString()} vieressä.");
            return false;
        }
    }
}
