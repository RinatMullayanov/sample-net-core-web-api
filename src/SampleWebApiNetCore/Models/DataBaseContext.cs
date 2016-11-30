using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApiNetCore.Models
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Well> Wells { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
        }
    }
}
