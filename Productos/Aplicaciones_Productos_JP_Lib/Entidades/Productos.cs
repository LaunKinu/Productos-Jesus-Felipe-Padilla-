namespace Aplicaciones_Productos_JP_Lib.Entidades
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateOnly Fecha_Compra { get; set; }

        public bool Validar()
        {
            return string.IsNullOrEmpty(this.Codigo) ||
                string.IsNullOrEmpty(this.Nombre) ||
                this.Precio <= 0.0m;

            /*Poner Fecha*/
        }
    }
}