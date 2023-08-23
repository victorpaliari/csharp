namespace Atividade_03 {
    internal class Program {
        static void Main(string[] args) {


            float bruto, valorHora, adcNoturno, horaExtra, descontos, salarioL, resNoturno, resExtra;
            int diasTrab;

            Console.WriteLine("Digite o salário bruto: ");
            bruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Quanto recebe de hora extra? ");
            horaExtra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quanto recebe de adicional noturno? ");
            adcNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite os descontos: "); 
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioL = (bruto + (adcNoturno + horaExtra) - descontos); 

            Console.WriteLine("Seu salário líquido é: R$" + salarioL + ".");
        }
    }
}