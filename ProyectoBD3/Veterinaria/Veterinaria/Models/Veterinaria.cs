using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class Veterinaria
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public List<Sucursal> sucursales { get; set; }
        public List<Moderador> moderadores { get; set; }
        public List<Cliente> clientes { get; set; }


        public Veterinaria()
        {
            this.sucursales = new List<Sucursal>();
            this.moderadores = new List<Moderador>();
            this.clientes = new List<Cliente>();
        }
    }
}
