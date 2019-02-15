using Api.Dao;
using Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace Api.Business_Logic
{
    public class UsuariosBL
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        Usuarios usuarios = new Usuarios();

        public async Task<Usuarios> GetUsuarioBL(string Usuario)
        {
            var query = await usuarioDao.GetUsuarioDao(Usuario);

            usuarios.Usuario = query.login;
            usuarios.Nombre = query.name;
            usuarios.Correo_Electronico = query.email;
            usuarios.Biografía = query.bio;
            usuarios.Imagen = query.avatar_url;

            return usuarios;
        }

    }
}