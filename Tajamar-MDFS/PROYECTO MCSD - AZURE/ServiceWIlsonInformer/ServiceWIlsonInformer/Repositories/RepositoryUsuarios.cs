

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ServiceWIlsonInformer.repositories;
using ServiceWIlsonInformer.Data;
using ServiceWIlsonInformer.Helpers;
using ServiceWIlsonInformer.Models;

namespace ServiceWIlsonInformer
{
    public class RepositoryUsuarios :IRepositoryUsuarios
    {
        PartesContext context;
        public RepositoryUsuarios(PartesContext context)
        {
            this.context = context;
        }
        public bool InsertUsuario(
            String nombre, 
            String username,
            String Apellido,
            String email,
            String Rol,
            String salt,
            byte[] pass
            ) {
            try
            {
                //String salt = CypherService.GetSalt();
                //byte[] pass = CypherService.Encrypt(password, salt);
                int userid = CheckLastId() + 1;
                Usuario usuario = new Usuario
                {
                    Id = userid,
                    Nombre = nombre,
                    User = username,
                    Apellido = Apellido,
                    Email = email,
                    Rol = Rol,
                    Salt = salt,
                    Pass = pass
                };

                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public Usuario Check(String username, String pass)
        {
            Usuario usuario = context.Usuarios.Where(x => x.User == username).FirstOrDefault();
            if(usuario == null)
            {
                return null;
            }
            else
            {
                String saltDB = usuario.Salt;
                byte[] passwordDB = usuario.Pass;
                byte[] passuser = CypherService.Encrypt(pass, saltDB);
                bool valid = ToolKit.CompareBytes(passuser, passwordDB);
                if (valid) return usuario;
                else return null;

            }
        }
        public int CheckLastId()
        {
            try
            {
                return context.Usuarios.Max(x => x.Id);
            }catch(Exception ex)
            {
                return 1;
            }
        }

        public bool Exist(string username,String email)
        {
            Usuario u = context.Usuarios.Where(x => x.User.ToLower() == username.ToLower()
                || x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            if (u == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
