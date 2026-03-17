namespace Seikkailijanreppu
{
    internal class SeikkailijaTavara
    {
        //parametrit
        public string TavaraNimi { get { return tavaraNimi; } set => tavaraNimi = value; }
        public float Paino { get { return paino; } set { paino = value; } }
        public float Tilavuus { get { return tilavuus; } set { tilavuus = value; } }

        protected string tavaraNimi;
        protected float paino;
        protected float tilavuus;

        public SeikkailijaTavara(string tavaraNimi, float paino, float tilavuus)
        {
            this.tavaraNimi = tavaraNimi;
            this.paino = paino;
            this.tilavuus = tilavuus;
        }

    }

    internal class Nuoli : SeikkailijaTavara
    {
        public Nuoli() : base("Nuoli", 0.1f, 0.05f) { }
    }

    internal class Jousi : SeikkailijaTavara
    {
        public Jousi() : base("Jousi", 1f, 4f) { }
    }

    internal class Koysi : SeikkailijaTavara
    {
        public Koysi() : base("Köysi", 1f, 1.5f) { }
    }

    internal class Vesi : SeikkailijaTavara
    {
        public Vesi() : base("Vesi", 2f, 2f) { }
    }

    internal class Ruokaannos : SeikkailijaTavara
    {
        public Ruokaannos() : base("Ruoka-annos", 1f, 0.5f) { }
    }

    internal class Miekka : SeikkailijaTavara
    {
        public Miekka() : base("Miekka", 5f, 3f) { }
    }
}