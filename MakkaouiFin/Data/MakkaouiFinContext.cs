using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MakkaouiFin.Models;

namespace MakkaouiFin.Data
{
    public class MakkaouiFinContext : DbContext
    {
        public MakkaouiFinContext (DbContextOptions<MakkaouiFinContext> options)
            : base(options)
        {
        }

        public DbSet<MakkaouiFin.Models.Movie> Movie { get; set; } = default!;
    }
}
