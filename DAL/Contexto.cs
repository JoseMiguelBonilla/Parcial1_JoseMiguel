using Microsoft.EntityFrameworkCore;
using Parcial1_JoseMiguel.Models;


namespace Parcial1_JoseMiguel.DAL
{
    public class Contexto : DbContext
    {
    
    public Contexto(DbContextOptions<Contexto> options ): base(options)
    {
        
    }
        public DbSet<Ingresos> Ingresos {get;set;}
        
    }
}


