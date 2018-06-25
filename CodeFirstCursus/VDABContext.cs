using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    public class VDABContext : DbContext
    {
        public DbSet<Instructeur> Instructeurs { get; set; }
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Land> Landen { get; set; }
        public DbSet<Cursus> Cursussen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KlassikaleCursus>().Map(m => m.Requires("Soort").HasValue("K"));
            modelBuilder.Entity<ZelfstudieCursus>().Map(m => m.Requires("Soort").HasValue("Z"));

            //test voor myBranchgit 
        }
    }
}
