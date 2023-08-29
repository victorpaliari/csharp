namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria o Hashset e inicializa com dados

            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan",
                "George",
                "Victor",
                "Mateus",

            

        };

            foreach (var nomes in setNomes)
            {
                Console.WriteLine(nomes);
            }

            //Adiciona elementos no HashSet
            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("João");

            
           
           foreach (var nomes in setNomes)
            {
                Console.WriteLine(nomes);
            }

            //Checa se existe um elemento no HashSet
            Console.WriteLine("O nome Julia existe? " + setNomes.Contains("Julia"));

            //Remove um elemento de HashSet
            setNomes.Remove("João");
            setNomes.Remove("Julia");

            foreach (var nomes in setNomes)
            {
                Console.WriteLine(nomes);   
            }

            //Converter um HashSet em uma list
            List<string> hashlist = setNomes.ToList();

            
            hashlist.Sort();

            foreach (var hash in hashlist)
            {
                Console.WriteLine(hash);
            }


        }
    }
}