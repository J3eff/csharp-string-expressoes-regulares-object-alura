using System;


namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if(string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));

            URL = url;
        }


    }
}
