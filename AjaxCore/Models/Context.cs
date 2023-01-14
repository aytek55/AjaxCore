using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace AjaxCore.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ALIAYTEKIN\\SQLEXPRESS; database=AjaxCore; Integrated Security=True;");

        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
