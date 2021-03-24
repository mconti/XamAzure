using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamAzureApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentiController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Studente> Get()
        {
            List<Studente> studenti = new List<Studente>();
            studenti.Add(new Studente { Nome = "Maurizio", Cognome = "Conti", Avatar = "maurizio.conti.png", EMail = "maurizio.conti@ittsrimini.edu.it" });
            studenti.Add(new Studente { Nome = "Fabio", Cognome = "Corbelli", Avatar = "fabio.corbelli.png", EMail = "fabio.corbelli@ittsrimini.edu.it" });
            studenti.Add(new Studente { Nome = "Riccardo", Cognome = "Bianchi", Avatar = "riccardo.bianchi.png", EMail = "riccardo.bianchi@ittsrimini.edu.it" });

            return studenti;
        }
    }
}
