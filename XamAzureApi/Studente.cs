using System;

namespace XamAzureApi
{
    public class Studente
    {
        private string URL { get; }
        public Studente()
        {
            URL = @"https://flr.azurewebsites.net/images/";
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string EMail { get; set; }
        public string Immagine { get; set; }
        public string URLImmagine { get { return URL + Immagine; } }
    }
}
