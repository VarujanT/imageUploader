using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tttt.Models;

namespace tttt.App_Data
{
    public class imageContext : DbContext
    {
        public imageContext(DbContextOptions<imageContext> options)
           : base(options)
        {
        }

        public DbSet<images> Images{ get; set; }
    }
}
