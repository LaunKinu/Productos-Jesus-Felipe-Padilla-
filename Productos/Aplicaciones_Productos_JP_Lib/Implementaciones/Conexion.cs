using Aplicaciones_Productos_JP_Lib.Entidades;
using Aplicaciones_Productos_JP_Lib.Interfaces;
using Aplicaciones_Productos_JP_Lib.Nucleo;
using Microsoft.EntityFrameworkCore;

namespace Aplicaciones_Productos_JP_Lib.Implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Productos>? Productos { get; set; }
    }
}
