using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionTablesAzure
{
    public class Alumno:TableEntity
    {
        private String _IdAlumno;
        public String IdAlumno
        {
            get 
            {
                return this._IdAlumno;
            }
            set 
            {
                this._IdAlumno = value;
                this.RowKey = value;
            }
        }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Nota { get; set; }
        public String _Curso;
        public String Curso
        {
            get
            {
                return this._Curso;
            }
            set
            {
                this._Curso = value;
                this.PartitionKey = value;
            }
        }
    }
}
