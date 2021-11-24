using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AssigmentManageStaff.Models
{
    public partial class DBstaffContext : DbContext
    {
        public DBstaffContext()
            : base("name=DBstaffContext")
        {
        }

        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staffs)
                .WithOptional(e => e.Position)
                .HasForeignKey(e => e.IdPosition);
        }
    }
}
