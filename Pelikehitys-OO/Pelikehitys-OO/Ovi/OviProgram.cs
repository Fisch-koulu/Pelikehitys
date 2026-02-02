namespace Ovi_enum
{
    internal class OviProgram
    {
        public enum OvenTila
        {

            Auki,
            Suljettu,
            Lukittu
        }

        static void Main(string[] args)
        {
            string[] oviKomento = Enum.GetNames<OvenTila>();
            OvenTila nyt = OvenTila.Auki;

            Console.Write("Ovi on Auki.");

            while (true)
            {
                Console.Write(" Mitä haluat tehdä? ");
                string valinta = Console.ReadLine();

                // Komento Aukaise
                // Aukaise(oventila)
                switch(valinta)
                {
                    case "avaa":
                        nyt = Aukaise(nyt);
                        break;
                    case "avaa lukko":
                        nyt = AukaiseLukko(nyt);
                        break;
                    case "sulje":
                        nyt = Sulje(nyt);
                        break;
                    case "lukitse":
                        nyt = Lukitse(nyt);
                        break;
                    default:
                        Console.Write($"Ovi on {Enum.GetName<OvenTila>}");
                        break;
                }
                
                /*if (valinta == "sulje" && nyt == OvenTila.Avaa)
                {
                    Console.WriteLine("OVI KIINNI VITTU ");
                } else if (valinta == "lukitse" && nyt == OvenTila.Sulje || valinta == "lukitse" && nyt == OvenTila.AvaaLukko)
                {
                    Console.WriteLine("OVI LUKKOON SAATANA ");
                } else if (valinta == "avaa lukko" && nyt == OvenTila.Lukitse)
                {
                    Console.WriteLine("OVI LUKKOON SAATANA ");
                } else if (valinta == "avaa" && nyt == OvenTila.Sulje || valinta == "avaa" && nyt == OvenTila.AvaaLukko)
                {
                    Console.WriteLine("OVI AUKI VITTU ");
                }*/

            }

        }

        // Aukaise
        private static OvenTila Aukaise(OvenTila tila)
        {
            switch (tila)
            {
                case OvenTila.Auki:
                    Console.Write("Ovi on jo Auki.");
                    return tila;
                case OvenTila.Lukittu:
                    Console.Write("Ovi on Lukittu. Lukko pitää avata.");
                    return tila;
                case OvenTila.Suljettu:
                    Console.Write("Ovi on Auki.");
                    return OvenTila.Auki; //tämä vaihtaa Oventilan oikeasti
                default:
                    Console.Write($"Ovi on {Enum.GetName<OvenTila>}");
                    return tila;
            }
        }

        // Aukaise lukko
        private static OvenTila AukaiseLukko(OvenTila tila) 
        { 
            switch (tila) 
            { 
                case OvenTila.Auki:
                    Console.Write("Ovea ei ole Lukittu ja se on Auki.");
                    return tila;
                case OvenTila.Lukittu:
                    Console.Write("Lukko Aukeaa.");
                    return OvenTila.Suljettu;
                case OvenTila.Suljettu:
                    Console.Write("Ovea ei ole Lukittu.");
                    return tila;
                default:
                    Console.Write($"Ovi on {Enum.GetName<OvenTila>}");
                    return tila;
            } 
        }

        // Sulje
        private static OvenTila Sulje(OvenTila tila)
        {
            switch (tila)
            {
                case OvenTila.Auki:
                    Console.Write("Ovi on Suljettu.");
                    return OvenTila.Suljettu;
                case OvenTila.Lukittu:
                    Console.Write("Ovi on Lukittu. Lukko pitää avata.");
                    return tila;
                case OvenTila.Suljettu:
                    Console.Write("Ovi on jo Suljettu.");
                    return tila;
                default:
                    Console.Write($"Ovi on {Enum.GetName<OvenTila>}");
                    return tila;
            }
        }

        // Lukitse
        private static OvenTila Lukitse(OvenTila tila)
        {
            switch (tila)
            {
                case OvenTila.Auki:
                    Console.Write("Ovi on Auki. Se pitää ensin Sulkea.");
                    return tila;
                case OvenTila.Lukittu:
                    Console.Write("Ovi on jo Lukittu.");
                    return tila;
                case OvenTila.Suljettu:
                    Console.Write("Ovi on Lukittu.");
                    return OvenTila.Lukittu;
                default:
                    Console.Write($"Ovi on {Enum.GetName<OvenTila>}");
                    return tila;
            }
        }
    }
}


