using MeriPustak.Models;
using Microsoft.EntityFrameworkCore;

namespace MeriPustak.DataAccess.Data
{
    public class MeriPustakDbContext : DbContext
    {
        public MeriPustakDbContext(DbContextOptions<MeriPustakDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

    }
}
