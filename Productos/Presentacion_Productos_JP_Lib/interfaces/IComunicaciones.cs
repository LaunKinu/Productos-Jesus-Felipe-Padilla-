namespace Presentaciones_Productos_JP_Lib.Interfaces
{
    public interface IComunicaciones
    {
        Task<T> Ejecutar<T>(string url, object entidad);
    }
}
