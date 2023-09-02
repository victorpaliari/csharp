namespace MetodosEPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Noah", "12.345.678-0", 24, "Rua das Flores, nº 0", "noah@gmail.com", 3089000);
            c1.Visualizar();

            Cliente c2 = new Cliente("Steve", "12.345.678-0", 19, "Rua Jacarei, nº 45", "steve019@gmail.com", 90);
            c2.Visualizar();

            PessoaFisica pf1 = new PessoaFisica("Victor", "13.141.516-1", 20, "City Hall", "victor@email.com", 10000000.00M, "123.765.234-20");
            pf1.Visualizar();

            PessoaFisica pf2 = new PessoaFisica("Filipe Ret", "10.005.245-5", 45, "Barueri", "filipe@email.com", 90000.00M, "876.000.256-12");
            pf2.Visualizar();

            PessoaJuridica pj1 = new PessoaJuridica("Xamã", "56.456.323-09", 34, "São Vicente", "xamaoficial@gmail.com", 450.00M, "765.345.345-07");
            pj1.Visualizar();

            PessoaJuridica pj2 = new PessoaJuridica("Hariel", "36.456.373-00", 78, "Osasco", "mchariel@gmail.com", 5433300.00M, "009.543.430-02");
            pj2.Visualizar();

        }
    }
}