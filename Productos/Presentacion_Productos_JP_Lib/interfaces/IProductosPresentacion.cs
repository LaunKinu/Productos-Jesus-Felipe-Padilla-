using Aplicaciones_Productos_JP_Lib.Entidades;

namespace Presentaciones_Productos_JP_Lib.Interfaces
{
    public interface IProductosPresentacion
    {
        Productos Insertar(Productos entidad);
        Productos Actualizar(Productos entidad);
        List<Productos> Consultar();
        List<Productos> Buscar(Productos entidad);
        Productos Borrar(Productos entidad);
    }
}