namespace Varitetyt_Tavarat
{
    internal class VariProgram
    {
        static void Main(string[] args)
        {
            Miekka testiMiekka = new Miekka();
            VaritettyTavara<Miekka> tuli = new VaritettyTavara<Miekka>(testiMiekka, ConsoleColor.Red);
            Jousi testiJousi = new Jousi();
            VaritettyTavara<Jousi> jaa = new VaritettyTavara<Jousi>(testiJousi, ConsoleColor.Blue);
           
            tuli.NaytaTavara();
            jaa.NaytaTavara();
        }
    }
}
