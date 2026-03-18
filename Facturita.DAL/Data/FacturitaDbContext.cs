using Microsoft.EntityFrameworkCore;
using Facturita.Core.Models;

namespace Facturita.DAL.Data
{
    public class FacturitaDbContext : DbContext
    {
        public FacturitaDbContext(DbContextOptions<FacturitaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraDetalle> CompraDetalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Venta>().ToTable("Ventas");
            modelBuilder.Entity<VentaDetalle>().ToTable("VentaDetalles");
            modelBuilder.Entity<Compra>().ToTable("Compras");
            modelBuilder.Entity<CompraDetalle>().ToTable("CompraDetalles");

            // Precision de decimales para importes/precios
            modelBuilder.Entity<Producto>()
                .Property(p => p.PrecioCompra)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Producto>()
                .Property(p => p.PrecioVenta)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Venta>()
                .Property(v => v.Total)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<VentaDetalle>()
                .Property(vd => vd.PrecioUnitario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<VentaDetalle>()
                .Property(vd => vd.Subtotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Compra>()
                .Property(c => c.Total)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CompraDetalle>()
                .Property(cd => cd.PrecioUnitario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CompraDetalle>()
                .Property(cd => cd.Subtotal)
                .HasColumnType("decimal(18,2)");
        }
    }
}
