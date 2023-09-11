namespace Triatleta
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Teste");
            Triatleta t1 = new Triatleta ("Victor");
            t1.Aquecer();
            t1.Correr();
            t1.Pedalar();
            t1.Nadar();
            t1.Cansou();
        }
    }
}