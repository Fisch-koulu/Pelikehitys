namespace Varitetyt_Tavarat
{
    internal class VaritettyTavara<T> where T : SeikkailijaTavara
    {
        private T tavara;
        private ConsoleColor vari;

        public VaritettyTavara(T tavara, ConsoleColor vari)
        {
            this.tavara = tavara;
            this.vari = vari;
        }

        public void NaytaTavara()
        {
            Console.ForegroundColor = vari;
            Console.WriteLine(tavara.ToString()); //unohdin laittaa () toStringin jälkeen :(
            Console.ResetColor();
        }
    }
}
