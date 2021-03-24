using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entities;
using Datos;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Negocio.Manager
{
   public class UsuarioManager
    {
        public int AltaUsuario (cUsuario usuario)
        {
            int existe;
            
            using (DBRegistroEntities db = new DBRegistroEntities())
            {
                try
                {
                    //Definicion parametros stored procedure
                    SqlParameter Nombre = new SqlParameter("@Nombre", usuario.Nombre);
                    SqlParameter Apellido = new SqlParameter("@Apellido", usuario.Apellido);
                    SqlParameter Email = new SqlParameter("@Email", usuario.Email);
                    SqlParameter Edad = new SqlParameter("@Edad", usuario.Edad);
                    SqlParameter Localidad = new SqlParameter("@Localidad", usuario.Localidad);
                    SqlParameter Usuario = new SqlParameter("@Usuario", usuario.Usuario);
                    SqlParameter Contraseña = new SqlParameter("@Contraseña", usuario.Contrasenia);

                    //Llamada al stoed procedure, paso de parametros y obtengo bandera
                     existe = Convert.ToInt32(db.Database.SqlQuery<int>("EXEC AltaUsuario @Nombre,@Apellido,@Email,@Edad,@Localidad,@Usuario,@Contraseña",
                        Nombre, Apellido, Email, Edad, Localidad, Usuario, Contraseña).FirstOrDefault());
                } catch(Exception)
                {
                    throw;
                }
                //Bandera utilizada en angular para devolver mensaje al usuario
                return existe;


            }       
        }
    }
}
