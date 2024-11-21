using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Futnatics.Data;

namespace Futnatics
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            
            // Substitua pela sua string de conexão
            optionsBuilder.UseSqlServer("SuaStringDeConexaoAqui");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
