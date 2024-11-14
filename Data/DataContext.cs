using Futnatics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Futnatics.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> CLIENTES { get; set; }
        public DbSet<Partida> PARTIDAS { get; set; }
        public DbSet<Ingresso> INGRESSOS { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("CLIENTES");
            modelBuilder.Entity<Partida>().ToTable("PARTIDAS");
            modelBuilder.Entity<Ingresso>().ToTable("INGRESSOS");
            
        
    

            modelBuilder.Entity<Cliente>().HasData
            (
                 new Cliente() { Id = 1, Nome = "Renan", Cpf = 546812798, Email = "Renanalmeidadantas2007@gmail.com" , Endereco = "Rua Jonas Cardoso N: 16B " , Rg = 1241454213},
                new Cliente { Id = 2, Nome = "Danillo", Cpf = 124345325, Email = "DanilloLacerdad470" ,Endereco = "Rua Serra Do Apodi", Rg = 235252436},
                new Cliente { Id = 3, Nome = "Felipe", Cpf = 21345235, Email = "FelipeSilva@gmail.com", Endereco = "Rua Elisa do Apodi", Rg = 123542253}
            );
            
            

            modelBuilder.Entity<Partida>().HasData 
            (
                new Partida() {Id = 1, Data = DateTime.Parse("04/11/2024 20:00"), Estadio = "Neo Quimica Arena", TimeCasa =  "Corinthians", TimeFora = "Palmeiras"},
                new Partida() {Id = 2, Data =  DateTime.Parse("09/11/2024 16:30"), Estadio = "Barradão", TimeCasa = "Vitoria", TimeFora = "Corinthians"}
            );
            
        }
        

        
            

           




    }

}

