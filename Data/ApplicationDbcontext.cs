using Microsoft.EntityFrameworkCore;
using LTS_PTPMQL_BKT.Models;

namespace LTS_PTPMQL_BKT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}