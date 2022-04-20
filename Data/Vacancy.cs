using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testweb.Data
	{
	public class Vacancy
	{
		[Key]
		public long Id {get;set;}
		public string Company { get; set; }
		public DateTime Date { get; set; }
	}
}
