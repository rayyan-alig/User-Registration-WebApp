using Microsoft.EntityFrameworkCore;
using RegistrationWeb.Models;
using System;

namespace RegistrationWeb.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Personal> Personaltable { get; set; }
        public DbSet<Edu> Edutable { get; set; }
        public DbSet<PrevEmp> PrevEmptable { get; set; }
        public DbSet<PersAss> PersAsstable { get; set; }
        public DbSet<Declaration> Declarationtable { get; set; }
    }
}
