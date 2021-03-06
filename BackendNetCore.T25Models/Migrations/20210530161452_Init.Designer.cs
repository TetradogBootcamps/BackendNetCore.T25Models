// <auto-generated />
using BackendNetCore.T25Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendNetCore.T25Models.Migrations
{
    [DbContext(typeof(T25Context))]
    [Migration("20210530161452_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_1.Articulo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FabricanteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_1.Fabricante", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_2.Departamento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Presupuesto")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_2.Empleado", b =>
                {
                    b.Property<string>("DNI")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("DNI");

                    b.ToTable("Emplados");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_3.Almacen", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Lugar")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Almacenes");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_3.Caja", b =>
                {
                    b.Property<string>("NumReferencia")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("AlmacenId")
                        .HasColumnType("int");

                    b.Property<string>("Contenido")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("NumReferencia");

                    b.ToTable("Cajas");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_4.Pelicula", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CalificacionEdad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("BackendNetCore.T25Models.Models.Ejercicio_4.Sala", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Salas");
                });
#pragma warning restore 612, 618
        }
    }
}
