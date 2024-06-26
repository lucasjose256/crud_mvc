using crud_mvc.Models;
using crud_mvc.Models.entity;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.service
{
    public class SqlLiteDbcontextClass :DbContext
    {
        public string DbPath{ get; }
        public SqlLiteDbcontextClass(DbContextOptions options):base(options)
        {
            DbPath="students.db";
        }

        public DbSet<Student> Students { get; set; }

    }
}
