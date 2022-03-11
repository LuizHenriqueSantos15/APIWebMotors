using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMotors.Models
{
    public class WebMotorsContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto>  Motos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I7KDD5F;Initial Catalog=WebMotorsAPI;Integrated Security=True");
        }

    }
}
