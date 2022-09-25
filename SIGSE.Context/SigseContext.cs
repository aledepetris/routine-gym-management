using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SIGSE.Entities;
using SIGSE.Entities.Auditoria;

namespace SIGSE.Context
{
    public class SigseContext : DbContext
    {
        private static SigseContext instancia;
        public static SigseContext obtenerInstancia()
        {
            if (instancia == null)
                instancia = new SigseContext();
            return instancia;
        }
        public SigseContext() : base("name=SigseContext")
        {
        }
        public virtual DbSet<Persona> personas { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Rol> roles { get; set; }
        public virtual DbSet<Permiso> permisos { get; set; }
        public virtual DbSet<Musculo> musculos { get; set; }
        public virtual DbSet<Ejercicio> ejercicios { get; set; }
        public virtual DbSet<TipoEjercicio> tipos_ejercicios { get; set; }
        public virtual DbSet<TipoEntrenamiento> tipos_entrenamientos { get; set; }
        public virtual DbSet<Objetivo> objetivos { get; set; }
        public virtual DbSet<Ciclo> ciclos { get; set; }
        public virtual DbSet<Semana> semanas { get; set; }
        public virtual DbSet<Dia> dias { get; set; }
        public virtual DbSet<EjercicioIntensidad> ejercicios_instesidad { get; set; }
        public virtual DbSet<Medida> medidas { get; set; }
        public virtual DbSet<AuditoriaLogin> auditoria_login { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasKey(p => p.idPersona);

            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.idUsuario)
                .HasMany(u => u.roles)
                .WithMany();

            modelBuilder.Entity<Rol>()
                .HasKey(r => r.idRol)
                .HasMany(r => r.permisos)
                .WithMany();

            modelBuilder.Entity<Permiso>()
                .HasKey(p => p.idPermiso);

            modelBuilder.Entity<Musculo>()
                .HasKey(m => m.idMusculo);

            modelBuilder.Entity<Ejercicio>()
                .HasKey(e => e.idEjercicio)
                .HasMany(e => e.musculos)
                .WithMany();

            modelBuilder.Entity<Ejercicio>()
                .HasKey(e => e.idEjercicio)
                .HasMany(e => e.tipos_ejercicios)
                .WithMany();

            modelBuilder.Entity<TipoEjercicio>()
                .HasKey(te => te.idTipoEjercicio);

            modelBuilder.Entity<TipoEntrenamiento>()
                .HasKey(te => te.idTipoEntrenamiento)
                .HasMany(te => te.tipos_ejercicios)
                .WithMany();

            modelBuilder.Entity<Objetivo>()
                .HasKey(o => o.idObjetivo);

            modelBuilder.Entity<Ciclo>()
                .HasKey(c => c.idCiclo)
                .HasMany(c => c.semanas);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Semana>()
                .HasKey(s => s.idSemana)
                .HasMany(s => s.dias);

            modelBuilder.Entity<Dia>()
                .HasKey(d => d.idDia)
                .HasMany(d => d.ejercicios);

            modelBuilder.Entity<EjercicioIntensidad>()
                .HasKey(ei => ei.idEjercicioIntensidad);

            modelBuilder.Entity<Medida>()
                .HasKey(m => m.IdMedida);

            modelBuilder.Entity<AuditoriaLogin>()
                .HasKey(a => a.idLogin);

        }

    }

}
