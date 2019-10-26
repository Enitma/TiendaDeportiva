using System.Collections.Generic;

namespace deportivo.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}