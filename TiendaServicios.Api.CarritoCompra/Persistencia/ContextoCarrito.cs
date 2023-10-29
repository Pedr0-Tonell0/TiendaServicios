using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.CarritoCompra.Modelo;

namespace TiendaServicios.Api.CarritoCompra.Persistencia
{
    public class ContextoCarrito : DbContext
    {
        public ContextoCarrito(DbContextOptions<ContextoCarrito> options) : base(options) { }

        public DbSet<CarritoSesion> CarritoSesion { get;set; }
        public DbSet<CarritoSesionDetalle> CarritoSesionDetalle { get; set; }

    }
}
