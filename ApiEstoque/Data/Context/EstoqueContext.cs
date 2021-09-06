using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class EstoqueContext : DbContext
    {
        public DbSet<Estoque> Estoque { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server = localhost; user id = root; persistsecurityinfo = True; sslmode = None; database = Estoque;Pwd=gabras", new MariaDbServerVersion(new Version()));
        }
    }
}
