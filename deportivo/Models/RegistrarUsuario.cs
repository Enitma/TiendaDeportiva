using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deportivo.Models
{
    public class RegistrarUsuario
    {
        public int Id { get; set; }
        
        public string Dni { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Usuario { get; set; }

        public string Contra { get; set; }

        
    }
}