using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceWIlsonInformer.Models;

namespace ServiceWIlsonInformer.repositories
{
    public interface IRepositoryUsuarios
    {
        public bool InsertUsuario(
            String nombre,
            String username,
            String Apellido,
            String email,
            String Rol,
            String salt,
            byte[] pass
            );
        public Usuario Check(String username, String pass);
        public bool Exist(String username,String email);
    }
}
