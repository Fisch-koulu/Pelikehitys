namespace Seikkailijanreppu
{
    internal class SeikkailijaReppu
    {
        int maxMaara = 11;
        float maxPaino;
        float maxTilavuus;

        List<SeikkailijaTavara> tavarat = new List<SeikkailijaTavara>();
        public bool Lisaa(SeikkailijaTavara tavara)
        {
            if (tavarat.Count == maxMaara)
            {
                return true;
            } else
            {
                tavarat.Add(tavara);
                return false;
            }
        }
    }
}
