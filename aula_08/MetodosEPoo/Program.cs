namespace MetodosEPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Victor", "12.345.678-0", 24, "Rua das Flores, nº 0", "victorrpaliari@gmail.com", 3000);


            cliente1.Visualizar();
            cliente1.SetNome("Noah");
            cliente1.SetIdade(77);
            cliente1.SetEmail("noah@gmail.com");
            cliente1.Visualizar();


            
        }
    }
}