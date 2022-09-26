using Microsoft.EntityFrameworkCore;
using myAplication.Models;
namespace myAplication.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PastaOrder> PastaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
