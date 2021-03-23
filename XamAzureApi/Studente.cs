using System;

namespace XamAzureApi
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string EMail { get; set; }
        public string Avatar { get; set; }
        public string Immagine { get { return "https://xamazureapi.conveyor.cloud/images/" + Avatar; } }
    }
}
