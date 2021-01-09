using Microsoft.EntityFrameworkCore;
using SolMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.Models
{
	public class MyContext:DbContext
	{
		public MyContext(DbContextOptions<MyContext> opt) : base(opt)
		{

		}
		public DbSet<Navbar> Pages { get; set; }
		public DbSet<Slider> Slides { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Fluent Api
			//modelBuilder.Entity<Navbar>().HasOne(ho => ho.Category).WithMany(wm => wm.Uruns).OnDelete(DeleteBehavior.SetNull);
		}
	}
}
