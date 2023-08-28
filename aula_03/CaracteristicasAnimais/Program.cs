namespace CaracteristicasAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? opcao, vertebrado, invertebrado, carnivoro, hematofago, herbivoro;
            Console.WriteLine("Olá, escolha uma característica para começar: ");
            Console.WriteLine("Vertebrado ou Invertebrado? ");
            opcao = Console.ReadLine();


            if (String.Equals(opcao, "vertebrado"))
            {
                Console.WriteLine("Escolha outra característica: ");
                Console.WriteLine("Ave ou Mamífero? ");
                vertebrado = Console.ReadLine();

                if (String.Equals(vertebrado, "ave"))
                {
                    Console.WriteLine("Carvívoro ou Onívoro? ");
                    carnivoro = Console.ReadLine();

                    if (String.Equals(carnivoro, "carnivoro"))
                        Console.WriteLine("Águia");

                    if (String.Equals(carnivoro, "onivoro"))
                        Console.WriteLine("Pomba");
                    
                }


                if (String.Equals(vertebrado, "mamifero"))
                {
                    Console.WriteLine("Herbivoro ou Onívoro? ");
                    herbivoro = Console.ReadLine();

                    if (String.Equals(herbivoro, "herbivoro"))
                        Console.WriteLine("Vaca");
                   
                    if (String.Equals(herbivoro, "onivoro"))
                        Console.WriteLine("Homem");
         
                }
            }

            if (String.Equals(opcao, "invertebrado"))
            {
                Console.WriteLine("Escolha outra característica: ");
                Console.WriteLine("Inseto ou Anelídio? ");
                invertebrado = Console.ReadLine();

                if (String.Equals(invertebrado, "inseto"))
                {
                    Console.WriteLine("Hematófago ou Herbívoro? ");
                    hematofago = Console.ReadLine();

                    if (String.Equals(hematofago, "hematofago"))
                        Console.WriteLine("Pulga");

                    if (String.Equals(hematofago, "herbivoro"))
                        Console.WriteLine(" Lagarta");

                }

                if (String.Equals(invertebrado, "anelideo"))
                {
                    Console.WriteLine("Hematófago ou Onívoro? ");
                    hematofago = Console.ReadLine();

                    if (String.Equals(hematofago, "hematofago"))
                        Console.WriteLine("Sanguessuga");

                    if (String.Equals(hematofago, "onivoro"))
                        Console.WriteLine("Minhoca");
 
                }




            }


        }
    }
}
            
            