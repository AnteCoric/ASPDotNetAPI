using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetAPI.Model
{
    public class ChampionsContext: DbContext
    {
        public ChampionsContext (DbContextOptions<ChampionsContext> options): base(options)
        {

        }

        public DbSet<Champion> Champions { get; set; }
    }
}
