using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Entities
{
    public class UsuarioResult
    {
        public string login { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string bio { get; set; }

        public string avatar_url { get; set; }
    }
}