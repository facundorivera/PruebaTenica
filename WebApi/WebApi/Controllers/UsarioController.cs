using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Negocio.Manager;
using Negocio.Entities;


namespace WebApi.Controllers
{
    public class UsarioController : ApiController
    {

        UsuarioManager Us = new UsuarioManager();
       
        [HttpPost]
        [Route("api/Usuario/altaUsuario")]
        public int altaUsuario([FromBody] cUsuario usuario)
        {
            try
            {
                return Convert.ToInt32(Us.AltaUsuario(usuario));

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}