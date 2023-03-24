using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Data
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext(DbContextOptions opcion) : base(opcion)
        { 
        
        }

        //DBSet
        public DbSet<Post> Posts { get; set; }

    }
}
