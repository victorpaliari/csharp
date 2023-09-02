namespace LojaDeGames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Produto produto1 = new Produto("HeadSet Hero", "Redragon", "Kabum", "10/2019", "Garantia de 1 ano", "Equipamento de Áudio e Vídeo", 190, 13);
            produto1.Visualizar();

            Produto produto2 = new Produto("Placa de Vídeo", "GeForce GTX", "GeForce", "08/2022", "Garantia de 1 ano", "Informática", 1900, 40);
            produto2.Visualizar();

            Jogo j1 = new Jogo("Stray", "Annapurna Interactive", "BlueTwelve Studio", "19 de julho de 2022", "Sem garantia", "Jogos e entretenimento", 112.95M, 0, "Console de jogos e PC");
            j1.Visualizar();
            j1.Promocionar();

            Jogo j2 = new Jogo("Detroid: Become Human", "Quantic Dream", "Quantic Dream", "25 de maio de 2018", "Sem garantia", "Jogos e entretenimento", 134.99M, 0, "Console de jogos e PC");
            j2.Visualizar();
            j2.Promocionar();

            Consoles console1 = new Consoles("Xbox Series X", "Microsoft", "Microsoft", "10 de Novembro de 2020", "1 ano", "Jogos e entretenimento", 2129.00M, 0, "2TB");
            console1.Visualizar();
            console1.Promocionar();

        }
    }
}
