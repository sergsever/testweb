using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace testweb.Data
{
	public class VacanciesContext :DbContext
	{
		public VacanciesContext() : base(GetOptions()) { }
		public static DbContextOptions<VacanciesContext> GetOptions()
		{
			string connectionString = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build().GetSection("connectionString").Value;
			DbContextOptions<VacanciesContext> res = new DbContextOptionsBuilder<VacanciesContext>().UseSqlServer(connectionString).Options;
			return res;
		}

		public DbSet<Vacancy> Vacancies { get; set;}
	protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Vacancy>().HasKey(v => v.Id);
			builder.Entity<Vacancy>().HasData(
				new Vacancy()
				{
					Id=1,
					Company = "First",
					Date = DateTime.Now
				},
				new Vacancy()
				{
					Id=2,
					Company = "Second",
					Date = DateTime.Now
				}
				);
				
			
		}

	}
}
