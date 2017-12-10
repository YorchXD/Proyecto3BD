using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class Medico
    {
        public string run { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public List<string> especialidades { get; set; }

        public Medico()
        {
            this.especialidades = new List<string>();
        }

    }
}
