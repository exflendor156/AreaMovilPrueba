using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Entities
{
    public class Usuarios
    {
        public string Usuario { get; set; }

        public string Nombre { get; set; }

        public string Correo_Electronico{ get; set; }

        public string Biografía { get; set; }

        public string Imagen { get; set; }
    }
}