using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalAPI.Model
{
    public class OpticaContext : DbContext
    {
        public OpticaContext(DbContextOptions<OpticaContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Examen>()
                .HasOne<Paciente>()
                .WithMany()
                .HasForeignKey(e => e.PacienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Examen>()
                .HasOne<Doctor>()
                .WithMany()
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
