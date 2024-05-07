using Microsoft.EntityFrameworkCore;
using PhoniaTask.Models;

namespace PhoniaTask.DAL
{
    public class PhoniaContext : DbContext
    {
        public PhoniaContext(DbContextOptions options) :base(options)
        { 
        }
        public DbSet<Category>Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CLASSOSERAMICEU\\SQLEXPRESS01;DataBase=Phonia106;Trusted_Connection=true;");
            base.OnConfiguring(options);
        }
    }
}
