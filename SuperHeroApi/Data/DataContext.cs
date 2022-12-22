namespace SuperHeroApi.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=superherodb; integrated security=true;");
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
