using System.Diagnostics;
using System.Security.Cryptography;

namespace Ruoka_annos
{
    public enum Paaraaka
    {
        nautaa,
        kanaa,
        kasviksia
    }
    public enum Lisuke
    {
        perunaa,
        riisiä,
        pastaa
    }
    public enum Kastike
    {
        curry,
        hapanimelä,
        pippuri,
        chili
    }
  
    public class Ateria
    {
        public Paaraaka paaraaka;
        public Lisuke lisuke;
        public Kastike kastike;

        /*public Ateria(Paaraaka paaraaka,  Lisuke lisuke, Kastike kastike)
        {
            this.paaraaka = paaraaka;
            this.lisuke = lisuke;
            this.kastike = kastike;
        }

        public Paaraaka AnnaPaa()
        {
            return paaraaka; //voi olla myös return this.paaraaka
        }*/

        public override string ToString()
        {
            return $"{paaraaka}, {lisuke} ja {kastike}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Paaraaka valittuP = Paaraaka.kanaa;
            Lisuke valittuL = Lisuke.perunaa;
            Kastike valittuK = Kastike.chili;*/

            Ateria at = new Ateria();

            // kysele käyttäjältä annoksen osat
            //jos haluaisin 3 ateriaa pitäisi tehdä for loop ja lista
            //pitäisi myös selvittää miten katsoa enum lista ja muuttaa ne otettaviksi stringeiksi
            Console.Write("Pääraaka-aine (nautaa, kanaa ja kasviksia): ");
            string valittu = Console.ReadLine();
            at.paaraaka = TarkistaPaa(at.paaraaka, valittu);

            Console.Write("Lisukkeet (perunaa, riisiä ja pastaa): ");
            valittu = Console.ReadLine();
            at.lisuke = TarkistaLisuke(at.lisuke, valittu);

            Console.Write("Kastike (pippuri, chili, pippuri ja curry): ");
            valittu = Console.ReadLine();
            at.kastike = TarkistaKastike(at.kastike, valittu);


            //näytä käyttäjän annos
            Console.WriteLine(at);
        }

        public static Paaraaka TarkistaPaa(Paaraaka paaraaka, string valinta)
        {
            switch (valinta)
            {
                case "nautaa":
                    return Paaraaka.nautaa;
                case "kanaa":
                    return Paaraaka.kanaa;
                case "kasviksia":
                    return Paaraaka.kasviksia;
                default:
                    Console.WriteLine("Ei ole listalla. Anamme kanaa.");
                    paaraaka = Paaraaka.nautaa;
                    return paaraaka;
            }
        }
        public static Lisuke TarkistaLisuke(Lisuke lisuke, string valinta)
        {
            switch (valinta)
            {
                case "perunaa":
                    return Lisuke.perunaa;
                case "riisiä":
                    return Lisuke.riisiä;
                case "pastaa":
                    return Lisuke.pastaa;
                default:
                    Console.WriteLine("Ei ole listalla. Anamme perunaa.");
                    return lisuke;
            }
        }

        public static Kastike TarkistaKastike(Kastike kastike, string valinta)
        {
            switch (valinta)
            {
                case "curry":
                    return Kastike.curry;
                case "hapanimelä":
                    return Kastike.hapanimelä;
                case "pippuri":
                    return Kastike.pippuri;
                case "chili":
                    return Kastike.chili;
                default:
                    Console.WriteLine("Ei ole listalla. Anamme chili.");
                    return kastike;
            }
        }
    }
}
