using Microsoft.EntityFrameworkCore;

namespace RabbitMQ.SqlServer.Publish
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=Test.RabbitMQ.SqlServer;User Id=sa;Password=1234@qwer;MultipleActiveResultSets=True");
        }
    }

    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return "Name:" + Name + ";Age:" + Age;
        }
    }
}