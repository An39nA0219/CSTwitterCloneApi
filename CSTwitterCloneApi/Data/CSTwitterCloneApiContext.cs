using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSTwitterCloneApi.Models;

namespace CSTwitterCloneApi.Data
{
    public class CSTwitterCloneApiContext : DbContext
    {
        public CSTwitterCloneApiContext (DbContextOptions<CSTwitterCloneApiContext> options)
            : base(options)
        {
        }

        public DbSet<CSTwitterCloneApi.Models.User> User { get; set; }
    }
}
