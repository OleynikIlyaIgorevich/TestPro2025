using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.DbContexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Cabinet> Cabitents { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<SubDepartment> SubDepartments { get; set; } = null!;
    public DbSet<Position> Positions { get; set; } = null!;
    public DbSet<Emploee> Emploees { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Document> Documents { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cabinet>(x =>
        {
            x.HasKey(c => c.Id);

           
        });

        modelBuilder.Entity<Department>(x =>
        {
            x.HasKey(d => d.Id);

        });

        modelBuilder.Entity<SubDepartment>(x =>
        {
            x.HasKey(sd => sd.Id);

            x.HasOne(sd => sd.Department)
                .WithMany(d => d.SubDepartments)
                .HasForeignKey(sd => sd.Id);
        });

        modelBuilder.Entity<Position>(x =>
        {
            x.HasKey(p => p.Id);


        });

        modelBuilder.Entity<Emploee>(x =>
        {
            x.HasKey(e => e.Id);

            x.HasOne(e => e.Cabinet)
                .WithMany(c => c.Emploees)
                .HasForeignKey(e => e.CabinetId);

            x.HasOne(e => e.SubDepartment)
                .WithMany(sd => sd.Emploees)
                .HasForeignKey(e => e.SubDepartmentId);

            x.HasOne(e => e.Position)
                .WithMany(p => p.Workers)
                .HasForeignKey(e => e.PositionId);
        });

        modelBuilder.Entity<Category>(x =>
        {
            x.HasKey(c => c.Id);


        });

        modelBuilder.Entity<Document>(x =>
        {
            x.HasKey(d => d.Id);


        });

        modelBuilder.Entity<Comment>(x =>
        {
            x.HasKey(c => c.Id);

            x.HasOne(c => c.Document)
                .WithMany(d => d.Comments)
                .HasForeignKey(c => c.DocumentId);

            x.HasOne(c => c.Emploee)
                .WithMany(d => d.Comments)
                .HasForeignKey(c => c.EmploeeId);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;database=emploeemanagementdb;user=root;password=12032003;",
            new MySqlServerVersion(new Version(8, 0, 40)));
    }
}
