using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
namespace ExercicioEFCoreCodeFirst
{
    public class IrpfContext : DbContext
    {
        // public static readonly LoggerFactory FabricaLogger = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
        public DbSet<Declaracao> Declaracoes { get; set; }
        public DbSet<Deducao> Deducoes { get; set; }
        public DbSet<Contribuinte> Contribuintes {get; set;}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            //.UseLoggerFactory(FabricaLogger)

           .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=IrpfDB;Trusted_Connection=True;");
        }
    }
}