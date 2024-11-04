using Microsoft.EntityFrameworkCore;
public class visitaContext : DbContext{

    public DbSet <Visita> visitas { get; set; }
    public visitaContext(DbContextOptions <visitaContext> options) : base(options) { }
}