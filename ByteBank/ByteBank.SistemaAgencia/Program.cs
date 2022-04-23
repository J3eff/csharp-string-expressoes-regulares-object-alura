using System;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022,04, 25);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine();
        }
       
    }
}
