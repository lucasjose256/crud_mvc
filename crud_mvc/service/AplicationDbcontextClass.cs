using crud_mvc.Models;
using crud_mvc.Models.entity;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.service
{
    public class AplicationDbcontextClass :DbContext
    {
        public AplicationDbcontextClass(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> Products { get; set; }

    }
}
