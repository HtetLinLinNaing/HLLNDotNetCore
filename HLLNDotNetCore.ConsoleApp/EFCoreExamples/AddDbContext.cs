using HLLNDotNetCore.ConsoleApp.Dtos;
using HLLNDotNetCore.ConsoleApp.services;
using Microsoft.EntityFrameworkCore;

namespace HLLNDotNetCore.ConsoleApp.EFCoreExamples {
    internal class AddDbContext : DbContext   
    {   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        internal int SaveChanges() {
            throw new NotImplementedException();
        }

        public DbSet<BlogDto> Blogs { get; set; }
    }
}
