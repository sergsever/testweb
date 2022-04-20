using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testweb.Data;

namespace testweb.Models
{
	public class VacansiesModel
	{
		private IDAO<Vacancy> dao { get; set; }
		public IEnumerable<Vacancy> Vacancies { get; set; }
		public VacansiesModel(IDAO<Vacancy> dao)
		{
			this.dao = dao;
			Vacancies = dao.GetAll();
		}
	}
}
