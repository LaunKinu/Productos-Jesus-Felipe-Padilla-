using Aplicaciones_Productos_JP_Lib.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Aplicaciones_Productos_JP_Lib.Interfaces
{
    public interface IConexion
    {
        DbSet<Productos>? Productos { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
