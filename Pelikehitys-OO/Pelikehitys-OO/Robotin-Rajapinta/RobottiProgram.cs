namespace Robotin_Rajapinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robotti = new Robotti();

            for (int i = 0; i < robotti.Käskyt.Length; i++)
            {
                Console.WriteLine("Mitä komentoja syötetään robtoille? Vaihtoehdot: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen.");
                string syote = Console.ReadLine().ToLower();
                


                switch(syote)
                {
                    case "käynnistä":
                        robotti.Käskyt[i] = new Kaynnista();
                        break;
                    case "sammuta":
                        robotti.Käskyt[i] = new Sammuta();
                        break;
                    case "ylös":
                        robotti.Käskyt[i] = new YlosKasky();
                        break;
                    case "alas":
                        robotti.Käskyt[i] = new AlasKasky();
                        break;
                    case "oikea":
                        robotti.Käskyt[i] = new OikeaKasky();
                        break;
                    case "vasen":
                        robotti.Käskyt[i] = new VasenKasky();
                        break;
                    default:
                        Console.WriteLine("Ei ole käsky");
                        i--;
                        break;
                }
            }

            robotti.Suorita(robotti);

        }
    }
}
