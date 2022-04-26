using System;


namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if(string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));

            
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        // moedaOrige=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            return "";
            //int indiceParametro = _argumentos.
        }

    }
}
