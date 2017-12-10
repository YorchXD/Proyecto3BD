using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class Sucursal
    {
        public string numPermiso { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public bool estado { get; set; }
        public List<Medico> medicos { get; set; }

        public Sucursal()
        {
            this.medicos = new List<Medico>();
        }
    }
}
