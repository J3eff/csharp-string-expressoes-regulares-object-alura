using System;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlParametros = "http://www.bytebank.com/combio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor);
            Console.ReadLine();

            //moedaOrigem=real&moedaDestino=dolar

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            Console.ReadLine();

            // valor imutavel
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao);
            Console.WriteLine(argumentos);
                                    

            Console.ReadLine();
        }

    }
}
