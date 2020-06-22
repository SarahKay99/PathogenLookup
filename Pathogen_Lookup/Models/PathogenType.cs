using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Pathogen_Lookup.Models
{
	public class PathogenType
	{
		public int Id { get; set; }
		public String Type { get; set; }
		public String URL { get; set; }
	}

	public class PathogenTypeDbContext : DbContext
	{
		public DbSet<PathogenType> PathogenTypes { get; set; }
	}
}