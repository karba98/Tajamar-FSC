using PracticaAdoRCastro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAdoRCastro.Data
{
    public class LibreriaContext
    {
        //VER REGION PROCEDIMIENTOS
        #region PROCEDIMIENTOS
        /*
         CREATE PROCEDURE GetLibrosByGenero @genero integer
        AS
        BEGIN

	        SELECT IdLibro,Titulo,Autor,Sinopsis,Imagen, gen.Genero from Libros
	        inner join Generos as gen
	        on gen.IdGenero = Libros.IdGenero
	        where gen.IdGenero=@genero
        END
        GO

        ------------------------------------------------------------------------------------


        CREATE PROCEDURE DeleteGenero @genero nvarchar(255)
        AS
        BEGIN

	        DELETE FROM Generos where Genero = @genero
	        
        END
        GO

        ------------------------------------------------------------------------------------

        CREATE PROCEDURE InsertLibro
        @genero integer,
        @id integer,
        @titulo nvarchar(500),
        @autor nvarchar(500),
        @sinopsis nvarchar(800),
        @imagen nvarchar(800)
        AS
        BEGIN

	        insert into libros values (@id,@titulo,@autor,@sinopsis,@imagen,@genero)
        END
        GO

         */
        #endregion

        SqlCommand command;
        SqlDataReader reader;
        SqlConnection connection;
        String cadena;

        SqlDataAdapter adapterGeneros;
        SqlDataAdapter adapterLibros;

        DataTable tablaLibros;
        DataTable tablaGeneros;
        public LibreriaContext()
        {
            String cadena ="Data Source=localhost;Initial Catalog=PRACTICA_ADO;Integrated Security=True";
            adapterLibros = new SqlDataAdapter("SELECT * from libros", cadena);
            adapterGeneros = new SqlDataAdapter("select * from Generos", cadena);

            this.tablaLibros = new DataTable();
            this.tablaGeneros = new DataTable();

            adapterLibros.Fill(tablaLibros);
            adapterGeneros.Fill(this.tablaGeneros);

            connection = new SqlConnection(cadena);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public List<Libro> GetLibros()
        {
            List<Libro> libros = new List<Libro>();
            var consulta = from res in this.tablaLibros.AsEnumerable()
                           select res;
            foreach(var row in consulta)
            {
                Libro lib = new Libro();
                lib.Autor = row.Field<String>("Autor");
                lib.Titulo = row.Field<String>("Titulo");
                lib.Sinopsis = row.Field<String>("Sinopsis");
                lib.Imagen = row.Field<String>("Imagen");
                lib.IdLibro = row.Field<int>("IdLibro");
                lib.IdGenero = row.Field<int>("IdGenero");
                libros.Add(lib);
            }
            return libros;
        }
        public Libro GetLibro(int id)
        {
            int g = id;
            var consulta = from res in this.tablaLibros.AsEnumerable()
                           where res.Field<int>("idLibro") == id
                           select res;
            var row = consulta.First();
            Libro lib = new Libro();
            lib.Autor = row.Field<String>("Autor");
            lib.Titulo = row.Field<String>("Titulo");
            lib.Sinopsis = row.Field<String>("Sinopsis");
            lib.Imagen = row.Field<String>("Imagen");
            lib.IdLibro = row.Field<int>("IdLibro");
            lib.IdGenero = row.Field<int>("IdGenero");
            
            return lib;
        }
        public String GetGenero(int id)
        {
            var consulta = from res in this.tablaGeneros.AsEnumerable()
                           where res.Field<int>("idGenero") == id
                           select res;
            var row = consulta.First();
            return row.Field<String>("Genero");
        }
        public int GetIdGenero(String genero)
        {
            var consulta = from res in this.tablaGeneros.AsEnumerable()
                           where res.Field<String>("Genero") == genero
                           select res;
            var row = consulta.First();
            return row.Field<int>("IdGenero");
        }
        public int GetLastIdGenero()
        {
            var consulta = from res in this.tablaGeneros.AsEnumerable()
                           select res;
            int maxvalue = consulta.Max(x => x.Field<int>("IdGenero"));

            return maxvalue;
        }
        public int UpdateLibro(
            int id, String titulo, String Autor, int genero, String Sinopsis)
        {
            command.Parameters.AddWithValue("@titulo", titulo);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@autor", Autor);
            command.Parameters.AddWithValue("@genero",genero);
            command.Parameters.AddWithValue("@sinopsis", Sinopsis);

            command.CommandType = CommandType.Text;
            command.CommandText = "update libros set titulo = @titulo, autor = @autor, " +
                "idGenero = @genero, sinopsis = @sinopsis where idLibro = @id";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }
        public List<String> GetAllGeneros()
        {
            List<String> generos = new List<String>();
            var consulta = from res in this.tablaGeneros.AsEnumerable()
                           select res;
            foreach (var row in consulta)
            {
                generos.Add(row.Field<String>("Genero"));
            }
            return generos;
        }
        public int DeleteGenero(String genero)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteGenero";
            command.Parameters.AddWithValue("@genero", genero);
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }

        public int AddGenero(String genero,int lastid)
        {
            try
            {
                command.Parameters.AddWithValue("@genero", genero);
                command.Parameters.AddWithValue("@id", lastid + 1);

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into generos values (@id,@genero)";
                connection.Open();
                int afectados = command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();
                return afectados;
            }
            catch(Exception ex)
            {
                connection.Close();
                command.Parameters.Clear();
                return 0;
            }
        }

        public int AddLibro(
            int id, String titulo, String Autor, int genero, String Sinopsis,String imagen)
        {
            try
            {
                command.Parameters.AddWithValue("@titulo", titulo);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@autor", Autor);
                command.Parameters.AddWithValue("@genero", genero);
                command.Parameters.AddWithValue("@sinopsis", Sinopsis);
                command.Parameters.AddWithValue("@imagen", imagen);

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertLibro";
                connection.Open();
                int afectados = command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();
                return afectados;
            }
            catch(Exception ex)
            {
                connection.Close();
                command.Parameters.Clear();
                return 0;
            }
 
        }
        public int GetLastIdLibro()
        {
            var consulta = from res in this.tablaLibros.AsEnumerable()
                           select res;
            int maxvalue = consulta.Max(x => x.Field<int>("IdLibro"));

            return maxvalue+1;
        }
        public List<Libro> GetLibrosPorGenero(String genero)
        {
            int idgenero = GetIdGenero(genero);
            List<Libro> libros = new List<Libro>();
            var consulta = from res in this.tablaLibros.AsEnumerable()
                           where res.Field<int>("IdGenero")==idgenero
                           select res;
            foreach (var row in consulta)
            {
                Libro lib = new Libro();
                lib.Autor = row.Field<String>("Autor");
                lib.Titulo = row.Field<String>("Titulo");
                lib.Sinopsis = row.Field<String>("Sinopsis");
                lib.Imagen = row.Field<String>("Imagen");
                lib.IdLibro = row.Field<int>("IdLibro");
                lib.IdGenero = row.Field<int>("IdGenero");
                libros.Add(lib);
            }
            return libros;
        }

    }
}
