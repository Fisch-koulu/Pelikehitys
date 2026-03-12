using System.Runtime.CompilerServices;

namespace Nuolia_Kaupan
{
        public enum Karki
        {
            puu,
            teräs,
            timantti
        }
        public enum Pera
        {
            lehti,
            kanansulka,
            kotkansulka
        }
    public class Nuoli
    {
        //parametrit
        public Karki Head 
        { 
            get { return karki; }
            set { karki = value; }
        }

        public Pera Back
        {
            get { return pera; }
            set { pera = value; }
        }

        public float Pituus
        {
            get { return pituus; }
            set {
                pituus = value;

                if (pituus < 60)
                    pituus = 60.0f;
                if (pituus > 100.0f)
                    pituus = 100.0f;
            }
        }
        //paremetri loppu (en muista mikä se oikea tapa oli tehdä tää, joten käytän vaan //)

        private Karki karki;
        private Pera pera;
        private float pituus;


        public Nuoli(Karki karki, Pera pera, float pituus)
        {
            this.karki = karki;
            this.pera = pera;
            this.pituus = pituus;
        }

        //jo luodut valmiit nuolet
        public static Nuoli LuoEliittiNuoli() 
        {
            Nuoli uus = new Nuoli(Karki.timantti, Pera.kotkansulka, 100f);
            return uus;
        }

        public static Nuoli LuoPerusNuoli() 
        {
            Nuoli uus = new Nuoli(Karki.teräs, Pera.kanansulka, 85f);
            return uus;
        }

        public static Nuoli LuoAloittelijaNuoli() 
        {
            Nuoli uus = new Nuoli(Karki.puu, Pera.lehti, 70f);
            return uus;
        }

        //vaihdetaan kärki
        /*public void AsetaKarki(Karki karki)
        {
            this.karki = karki;
        }
        //vaihdetaan perä
        public void AsetaPera(Pera pera)
        {
            this.pera = pera;
        }
        //aseta pituus
        public void AsetaPituus(float pituus)
        {
            this.pituus = pituus;
        }*/

        public float PalautaHinta()
        {
            // Laske hinta karjen, peran ja pituuden mukaan

            float hinta = 0; 
            switch (karki) {
                case Karki.puu:
                    hinta += 3; break;
                case Karki.teräs:
                    hinta += 5; break;
                case Karki.timantti:
                    hinta += 50; break;
            }
            switch (pera)
            {
                case Pera.lehti:
                    hinta += 0; break;
                case Pera.kanansulka:
                    hinta += 1; break;
                case Pera.kotkansulka:
                    hinta += 5; break;
            }
            hinta += pituus * 0.05f;
            //palauta lopuksi hinta
            return hinta;
        }
    }

    internal class NuoliProgram
    {
        static void Main(string[] args)
        {

            Console.Write("Tervetuloa nuolikauppaan.");
            Console.Write("Haluatko:\n1. Teettää nuolen tilaustyönä?\n2. Ostaa valmiin nuolen?\nValinta: ");

                Nuoli uusiNuoli = new Nuoli(Karki.puu, Pera.lehti, 60f);
            int kumpi = int.Parse(Console.ReadLine());
            Console.Clear();
            if (kumpi == 1)
            {
                string nuoliVastaus;
                float nuoliNumero;

                //kysyy käyttäjältä nuolen perän materiaalin
                Console.Write("Minkälainen kärki (puu, teräs, timantti)?: ");
                nuoliVastaus = Console.ReadLine();
                //uusiNuoli kärki muutetaan käyttäjän antamaksi kärjeksi (jos on kirjoitettu oikean ja metodissa)
                uusiNuoli.Head = UusiKarki(nuoliVastaus);

                //kysyy käyttäjältä nuolen perän(sulan) materiaalin
                Console.Write("Minkälaiset sulat (lehti, kanansulka, kotkansulka)?: ");
                nuoliVastaus = Console.ReadLine();
                //sama asia kuin kärki mutta muutetaan perä käyttäjän antamaksi
                uusiNuoli.Back = UusiPera(nuoliVastaus);

                //kysyy käyttäjältä nuolen pituuden
                Console.Write("Nuolen pituus sentteinä (60-100)?: ");
                nuoliVastaus = Console.ReadLine();
                //muuttaa nuolivastauksen kokonaisluvuksi
                nuoliNumero = float.Parse(nuoliVastaus);

                //käyttäjä ei antaa yli tai ali 60-100 (jos antaa niin se muuttaa numeron 60, jos alle, ja 100 jos yli)
                uusiNuoli.Pituus = nuoliNumero;

                Console.WriteLine($"\nTämän nuolen hinta on {uusiNuoli.PalautaHinta()} kultarahaa.");
            }
            else
            {
                Console.WriteLine("Valitse valmis nuoli:\n1. Eliittinuoli\n2. Aloittelijanuoli\n3. Perusnuoli\n");
                kumpi = int.Parse(Console.ReadLine());
                switch (kumpi)
                {
                    case 1:
                        uusiNuoli = Nuoli.LuoEliittiNuoli();
                        Console.WriteLine($"Valitsemasi nuolen hinta on {uusiNuoli.PalautaHinta()} kultarahaa.");
                        break;
                    case 2:
                        uusiNuoli = Nuoli.LuoPerusNuoli();
                        Console.WriteLine($"Valitsemasi nuolen hinta on {uusiNuoli.PalautaHinta()} kultarahaa.");
                        break;
                    case 3:
                        uusiNuoli = Nuoli.LuoAloittelijaNuoli();
                        Console.WriteLine($"Valitsemasi nuolen hinta on {uusiNuoli.PalautaHinta()} kultarahaa.");
                        break;
                    default:
                        uusiNuoli = Nuoli.LuoPerusNuoli();
                        Console.WriteLine($"Valitsemasi nuolen hinta on {uusiNuoli.PalautaHinta()} kultarahaa.");
                        break;
                }
            }
        }

        //muutta stringin oikeaksi Enumiksi
        public static Karki UusiKarki(string uusi)
        {
            switch(uusi)
            {
                case "puu": 
                    return Karki.puu;
                case "teräs":
                    return Karki.teräs;
                case "timantti":
                    return Karki.timantti;
                default:
                    return Karki.puu;
            }
        }

        //muutta stringin oikeaksi Enumiksi
        public static Pera UusiPera(string uusi)
        {
            switch(uusi)
            {
                case "lehti": 
                    return Pera.lehti;
                case "kanansulka":
                    return Pera.kanansulka;
                case "kotkansulka":
                    return Pera.kotkansulka;
                default:
                    return Pera.lehti;
            }
        }
    }
}
