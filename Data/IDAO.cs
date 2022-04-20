using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testweb.Data
{
	public interface IDAO<Entity>
	{
		IEnumerable<Entity> GetAll();
	}
}
