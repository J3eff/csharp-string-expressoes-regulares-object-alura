using System;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
           // valor imutavel
           string url = "pagina?argumentos";
                    
            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
       
    }
}
