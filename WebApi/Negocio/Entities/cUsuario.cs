using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Negocio.Entities
{
    public class cUsuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Localidad { get; set; }
        public int Edad { get; set; }
         
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

    }
}
