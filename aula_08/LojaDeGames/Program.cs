namespace LojaDeGames
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Produto produto1 = new Produto("HeadSet Hero", "Redragon", "Kabum", "10/2019", "Garantia de 1 ano", "Equipamento de Áudio e Vídeo", 190, 13, "Nota fiscal Paulista");
            {

            
            produto1.SetPreco(120);
            produto1.Visualizar();
            produto1.SetNome("Fone com fio");
            produto1.Promocionar();
            produto1.Visualizar();

            }


            Produto produto2 = new Produto("Placa de Vídeo", "GeForce GTX", "GeForce", "08/2022", "Garantia de 1 ano", "Informática", 1900, 40, "Nota fiscal Paulista");

            {

            
            produto1.SetPreco(3000);
            produto1.Visualizar();
            produto1.SetNome("Placa de Vídeo 3060");
            produto2.SetFabricante("GeForce RTX");
                produto1.Visualizar();
                produto1.Promocionar();
            produto1.Visualizar();
            
            }
        }
    }
}