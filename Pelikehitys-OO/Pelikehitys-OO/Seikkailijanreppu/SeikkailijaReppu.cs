using System.Runtime.CompilerServices;

namespace Seikkailijanreppu
{
    internal class SeikkailijaReppu
    {
        //tavaroiden max arvot
        int maxMaara = 10;
        float maxPaino = 30;
        float maxTilavuus = 20;

        //taveroiden nykyiset arvot
        float nytPaino;
        float nytTilavuus;
        
        public float NytPaino { get { return nytPaino; } set { nytPaino = value; } }
        public float NytTilavuus { get { return nytTilavuus; } set { nytTilavuus = value; } }

        //tekee listan tavaroille
        private List<SeikkailijaTavara> tavarat = new List<SeikkailijaTavara>();

        public SeikkailijaReppu() { }

        public bool YritaLisaa(SeikkailijaTavara tavara)
        {
            //tarkistaa ettei uusi esine ylitä max määrää, painoa tai tilavuutta.
            //tarkistaa myös, ettei paino ylity VAIKKA olisi vielä tilaa.
            if (tavarat.Count + 1 <= maxMaara && tavara.Paino + nytPaino <= maxPaino && tavara.Tilavuus + nytTilavuus <= maxTilavuus)
            {
                tavarat.Add(tavara);
                nytPaino += tavara.Paino;
                nytTilavuus += tavara.Tilavuus;
                return true;
            }
            Console.WriteLine("Kapasiteetti on saavutettu.");
            return false;
        }

        public override string ToString()
        {

            string sisalto = "Repussa on seuraavat tavarat: ";
            int paljon = tavarat.Count;
            for (int i = 0; i < paljon; i++)
            {
                //tarkistaako onko tavara viimeinen
                if (i < paljon - 1)
                {
                    //lisää nimet sisältöön ", " kanssa
                    sisalto += tavarat[i].ToString() + ", ";
                } else
                {
                    //ei lisää ", " loppuun
                    sisalto += tavarat[i].ToString();
                }
            }
            return sisalto;
        }

        public int AnnaMaara()
        {
            return tavarat.Count;
        }
    }
}
