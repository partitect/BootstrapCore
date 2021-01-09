using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstSpp.Models
{
	public class MyContext:DbContext
	{
		public MyContext(DbContextOptions<MyContext> opt) : base(opt)
		{

		}
		public DbSet<Urunler> Urunler { get; set; }
		public DbSet<Category> Category { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Fluent Api
			modelBuilder.Entity<Urunler>().HasOne(ho => ho.Category).WithMany(wm => wm.Uruns).OnDelete(DeleteBehavior.SetNull);
		}
	}
}
