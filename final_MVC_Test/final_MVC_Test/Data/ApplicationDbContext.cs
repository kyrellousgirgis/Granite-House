using final_MVC_Test.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace final_MVC_Test.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public virtual DbSet<ProductType> ProductTypes { get; set; }
		public virtual DbSet<SpecialTag> SpecialTags { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Appointment> Appointments { get; set; }
		public  DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ProductsSelectedForAppointment> ProductsSelectedForAppointments { get; set; }

    }
}
