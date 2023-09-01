namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notass = new List<double>();
            
            notass.Add(7.0);
            notass.Add(5.0);
            notass.Add(4.0);
            notass.Add(7.0);
            notass.Add(10.0);

            foreach (double nota in notass)
            {
                Console.WriteLine(nota);
            }
            
            Console.WriteLine("Posição da nota 4.0 " + notass.IndexOf(4.0));
            Console.WriteLine("A nota 4.0 existe? " + notass.Contains(4.0));
            notass.Remove(4.0);
        }
    }
}