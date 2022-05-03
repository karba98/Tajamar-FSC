using MvcCore.Data;
using MvcCore.Helpers;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Repositories._4_USUARIOS
{
    public class RepositoryUsuarios 
    {
        HospitalContext context;
        public RepositoryUsuarios(HospitalContext context)
        {
            this.context = context;
        }
        public bool InsertUsuario(int id, String nombre, String username, String password) {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Id = id;
                usuario.Nombre = nombre;
                usuario.User = username;
                String salt = CypherService.GetSalt();
                usuario.Salt = salt;
                byte[] pass = CypherService.Encrypt(password, salt);
                usuario.Pass = pass;

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
    }
}
