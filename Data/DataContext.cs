using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futnatics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Futnatics.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> CLIENTES { get; set; }
        public DbSet<Partida> PARTIDAS { get; set; }
        public DbSet<Time> TIMES { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("CLIENTES");
            modelBuilder.Entity<Partida>().ToTable("PARTIDAS");
            modelBuilder.Entity<Time>().ToTable("TIMES");
            
        
    

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

            modelBuilder.Entity<Time>().HasData
            (
                 new Time() {Id = 1,
             Nome = "Corinthians",
              Sigla = "Sccp",
               FundadoEm = new DateTime(1910 ,10, 01),
             Cidade = "São Paulo",
              Estado = "SP",
               Pais = "Brasil",
                Estadio = "Neo Quimica Arena",
                 MaiorRival = "Palmeiras",
                  Mascote = "Mosqueteiro",
                   Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ"},

              new Time
        {
            Id = 2,
            Nome = "São Paulo",
            Sigla = "SPFC",
            FundadoEm = new DateTime(1930, 12, 25),
            Cidade = "São Paulo",
            Estado = "SP",
            Pais = "Brasil",
            Estadio = "Morumbi",
            MaiorRival = "Corinthians",
            Mascote = "Santo Paulo",
            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI"
        },
         new Time
        {
            Id = 3,
            Nome = "Cruzeiro",
            Sigla = "Cru",
            FundadoEm = new DateTime(1921, 01, 02),
            Cidade = "Belo Horizonte",
            Estado = "BH",
            Pais = "Brasil",
            Estadio = "Mineirão",
            MaiorRival = "Atlético Mg",
            Mascote = "Raposa",
            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI"
        },

        new Time
        {
            Id = 4,
            Nome =  "Bragantino",
            Sigla =  "Bra",
            FundadoEm =  new DateTime(1928, 01, 28),
            Cidade =  "Bragança Paulista",
            Estado =  "SP",
            Pais =  "Brasil",
            Estadio =  "Nabi Abi Chedid",
            MaiorRival =  "Corinthians",
            Mascote =  "Touro",
            Logo =  "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ"
        }
            );
             base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveColumnType("varchar").HaveMaxLength(350);

            base.ConfigureConventions(configurationBuilder);
        }

        

        
            

           




    }

}

