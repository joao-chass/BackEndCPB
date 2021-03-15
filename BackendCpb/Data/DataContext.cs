using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendCpb.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendCpb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {

        }

        public DbSet<Noticia> Noticia { get; set; }
    }
}
