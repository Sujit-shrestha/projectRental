using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SemesterPorject.Models;

namespace SemesterPorject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        //dbset is required in DbContext to make a table in database 
        public DbSet<RentalSpaceModel> RentalSpace { get; set; }
    }
}
