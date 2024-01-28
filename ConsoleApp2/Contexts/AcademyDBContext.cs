using ConsoleApp2.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
public class AcademyDBContext : DbContext
{
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<ConsoleApp2.Entities.Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set; }
    public DbSet<GroupLecture> GroupsLectures { get; set; }
    public DbSet<GroupStudent> GroupsStudents { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string az = "Data Source=STHQ0122-02;Initial Catalog=Libraryhw;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";
            optionsBuilder.UseSqlServer(az);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>()
            .HasIndex(d => d.Name)
            .IsUnique();

        modelBuilder.Entity<ConsoleApp2.Entities.Group>()
            .HasIndex(g => g.Name)
            .IsUnique();

        modelBuilder.Entity<Faculty>()
            .HasIndex(f => f.Name)
            .IsUnique();

        modelBuilder.Entity<Subject>()
            .HasIndex(s => s.Name)
            .IsUnique();

        modelBuilder.Entity<Teacher>()
            .Property(t => t.IsProfessor)
            .HasDefaultValue(false);

    }
}
