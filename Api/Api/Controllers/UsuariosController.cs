using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Api.Business_Logic;
using Api.Dao;
using Api.Entities;

namespace Api.Controllers
{
    public class UsuariosController : ApiController
    {
        UsuariosBL usuarioBl = new UsuariosBL();

        /// <summary>
        /// Retorna la información del usuario
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        // GET: api/Usuarios
        public Task<Usuarios> GetUsuario(string Usuario)
        {
            return usuarioBl.GetUsuarioBL(Usuario);
        }
    }
}