using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testweb.Data
{
	public class VacancyDAO : IDAO<Vacancy>
	{
		private VacanciesContext dbcontext { get; set; }

		public VacancyDAO(VacanciesContext dbcontext)
		{
			this.dbcontext = dbcontext;
		}
		public IEnumerable<Vacancy> GetAll()
		{
			List<Vacancy> res = dbcontext.Vacancies.ToList();
			return res;
		}
	}
}
