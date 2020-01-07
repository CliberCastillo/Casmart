using System;
using Buses.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Buses.Entities
{
    public partial class AgenciaBusesContext : IdentityDbContext<AplicationUser,AplicationRole,string>
    { 
        public AgenciaBusesContext()
        {
        }
        public AgenciaBusesContext(DbContextOptions<AgenciaBusesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AsientoBus> AsientoBus { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Facturacion> Facturacion { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<ItinerarioViaje> ItinerarioViaje { get; set; }
        public virtual DbSet<Pasaje> Pasaje { get; set; }
        public virtual DbSet<Pasajero> Pasajero { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<UsuarioEmpleado> UsuarioEmpleado { get; set; }
        public virtual DbSet<UsuarioPasajero> UsuarioPasajero { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Agencia>(entity =>
            {
                entity.HasKey(e => e.IdAgencia);

                entity.Property(e => e.IdAgencia)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpostal)
                    .IsRequired()
                    .HasColumnName("CPostal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoAgencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAgencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.CpostalNavigation)
                    .WithMany(p => p.Agencia)
                    .HasForeignKey(d => d.Cpostal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENCIA_CPOSTAL");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.Property(e => e.IdArea)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreArea)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsientoBus>(entity =>
            {
                entity.HasKey(e => e.IdAsientoBus);

                entity.Property(e => e.IdAsientoBus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdBus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAsiento)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBusNavigation)
                    .WithMany(p => p.AsientoBus)
                    .HasForeignKey(d => d.IdBus)
                    .HasConstraintName("FK_ASIENTOBUS_IDBUS");
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.IdBus);

                entity.Property(e => e.IdBus)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EstadoBus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo);

                entity.Property(e => e.IdCargo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdArea)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCargo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Cargo)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CARGO_IDAREA");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.Property(e => e.IdDepartamento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreDepartamento)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.HasKey(e => e.Cpostal);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPostal")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Idprovincia)
                    .IsRequired()
                    .HasColumnName("IDProvincia")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDistrito)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdprovinciaNavigation)
                    .WithMany(p => p.Distrito)
                    .HasForeignKey(d => d.Idprovincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRITO_IDPROVINCIA");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdCargo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLEADO_IDAREA");
            });

            modelBuilder.Entity<Facturacion>(entity =>
            {
                entity.HasKey(e => e.NroFacturacion);

                entity.Property(e => e.NroFacturacion)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.IdformaPago)
                    .IsRequired()
                    .HasColumnName("IDFormaPago")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Igv)
                    .HasColumnName("IGV")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.NroPasaje)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Total).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.IdformaPagoNavigation)
                    .WithMany(p => p.Facturacion)
                    .HasForeignKey(d => d.IdformaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACTURACION_IDFORMAPAGO");

                entity.HasOne(d => d.NroPasajeNavigation)
                    .WithMany(p => p.Facturacion)
                    .HasForeignKey(d => d.NroPasaje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACTURACION_IDPASAJE");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago);

                entity.Property(e => e.IdFormaPago)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreFormaPago)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItinerarioViaje>(entity =>
            {
                entity.HasKey(e => e.IdItinerario);

                entity.Property(e => e.IdItinerario)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenciaDestino)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgenciaOrigen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HoraViaje).HasColumnType("datetime");

                entity.Property(e => e.IdAgencia)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdBus)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioViaje).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.ItinerarioViaje)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITINERARIO_VIAJE_IDVIAJE");

                entity.HasOne(d => d.IdBusNavigation)
                    .WithMany(p => p.ItinerarioViaje)
                    .HasForeignKey(d => d.IdBus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITINERARIO_VIAJE_IDBUS");
            });

            modelBuilder.Entity<Pasaje>(entity =>
            {
                entity.HasKey(e => e.NroPasaje);

                entity.Property(e => e.NroPasaje)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaViaje).HasColumnType("date");

                entity.Property(e => e.IdEmpleado)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdItinerario)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdPasajero)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdReserva)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdItinerarioNavigation)
                    .WithMany(p => p.Pasaje)
                    .HasForeignKey(d => d.IdItinerario)
                    .HasConstraintName("FK_PASAJE_IDITINERARIO");

                entity.HasOne(d => d.IdPasajeroNavigation)
                    .WithMany(p => p.Pasaje)
                    .HasForeignKey(d => d.IdPasajero)
                    .HasConstraintName("FK_PASAJE_IDPASAJERO");

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.Pasaje)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK_PASAJE_IDRESERVA");
            });

            modelBuilder.Entity<Pasajero>(entity =>
            {
                entity.HasKey(e => e.IdPasajero);

                entity.Property(e => e.IdPasajero)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.IdProvincia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdDepartamento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROVINCIA_IDDEPARTAMENTO");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);

                entity.Property(e => e.IdReserva)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLimite).HasColumnType("date");

                entity.Property(e => e.FechaReserva).HasColumnType("date");

                entity.Property(e => e.IdEmpleado)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdItinerario)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdPasajero)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_RESERVA_IDEMPLEADO");

                entity.HasOne(d => d.IdItinerarioNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.IdItinerario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVA_IDITINERARIO");
            });

            modelBuilder.Entity<UsuarioEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idempleado)
                    .HasColumnName("IDEmpleado")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdempleadoNavigation)
                    .WithMany(p => p.UsuarioEmpleado)
                    .HasForeignKey(d => d.Idempleado)
                    .HasConstraintName("FK_USUARIO_EMPLEADO_IDAREA");
            });

            modelBuilder.Entity<UsuarioPasajero>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPasajero);

                entity.Property(e => e.IdUsuarioPasajero)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idpasajero)
                    .HasColumnName("IDPasajero")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdpasajeroNavigation)
                    .WithMany(p => p.UsuarioPasajero)
                    .HasForeignKey(d => d.Idpasajero)
                    .HasConstraintName("FK_USUARIO_PASAJERO_IDPASAJERO");
            });
        }
    }
}
