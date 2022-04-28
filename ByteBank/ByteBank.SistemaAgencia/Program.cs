using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("47136322871");

            string  contaToString = conta.ToString();
            
            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);

            Console.ReadLine();
        }

        static void TestaString()
        {
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do numero 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            // "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // "[0-9]{4,5}[-][0-9]{4}";
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            // 879.546.120-20
            // 879546120-20

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 98871-5456";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();

            string urlTest = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTest.IndexOf("https://www.bytebank.com/");

            Console.WriteLine(urlTest.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTest.EndsWith("cambio/"));

            Console.WriteLine(urlTest.Contains("bytebank"));

            Console.ReadLine();

            // pagina?argumento
            // 012345678

            //moedaOrigem = real & moedaDestino = dolar

            string urlParametros = "http://www.bytebank.com/combio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorMoedaOrigem = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            string valorMoedaDestino = extrator.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);

            Console.WriteLine(extrator.GetValor("VALOR"));

            Console.ReadLine();


            // Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            //Testa Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);
            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            // Testando o método remove
            string testeRemocao = "primeiraParte&parteParRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();

            // <nome>=<valor>
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
        }

    }
}
