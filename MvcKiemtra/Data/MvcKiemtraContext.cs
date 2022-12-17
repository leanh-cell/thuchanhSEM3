using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcKiemtra.Models;

namespace MvcKiemtra.Data
{
    public class MvcKiemtraContext : DbContext
    {
        public MvcKiemtraContext (DbContextOptions<MvcKiemtraContext> options)
            : base(options)
        {
        }

        public DbSet<MvcKiemtra.Models.Employee> Employee { get; set; } = default!;
    }
}
