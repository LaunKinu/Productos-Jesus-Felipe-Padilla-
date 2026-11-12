using Aplicaciones_Productos_JP_Lib.Entidades;

namespace Aplicaciones_Productos_JP_Lib.Interfaces
{
    public interface IProductosAplicacion
    {
        Productos Insertar(Productos entidad);
        Productos Actualizar(Productos entidad);
        List<Productos> Consultar();
        List<Productos> Buscar(Productos entidad);
        Productos Borrar(Productos entidad);
    }
}