using System.ComponentModel.DataAnnotations.Schema;

namespace XO.DB.SQL
{
    public class Producto
    {
        public int Id { get; set; }

        public int IdTipo { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [ForeignKey("IdTipo")]
        public virtual TipoProducto Tipo { get; set; }
    }
}
