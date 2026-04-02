namespace Seikkailijanreppu
{
    internal class SeikkailijaProgram
    {
        static void Main(string[] args)
        {
            SeikkailijaReppu reppu = new SeikkailijaReppu();

            while (true)
            {
                Console.WriteLine($"Repussa on tällä hetkellä {reppu.AnnaMaara()}/10 tavaraa, {reppu.NytPaino}/30 painoa ja {reppu.NytTilavuus}/20 tilavuus." +
                    $"Mitä haluat lisätä?\n" +
                    $"1 - Nuoli\n" +
                    $"2 - Jousi\n" +
                    $"3 - Köysi\n" +
                    $"4 - Vettä\n" +
                    $"5 - Ruokaa\n" +
                    $"6 - Miekka");

                string vastaus = Console.ReadLine();
                reppu.YritaLisaa(LisaaTavara(vastaus));
            }
        }

        //välittää kättäjän vastauksen funktiolle, joka palauttaa oikean SeikkailijaTavara luokan
        //(en tiedä miten tehdä paremmin)
        public static SeikkailijaTavara LisaaTavara(string tavara)
        {
            switch (tavara)
            {
                case "1":
                    return new Nuoli();
                case "2":
                    return new Jousi();
                case "3":
                    return new Koysi();
                case "4":
                    return new Vesi();
                case "5":
                    return new Ruokaannos();
                case "6":
                    return new Miekka();
                default:
                    return new Nuoli();
            }
        }
    }
}
