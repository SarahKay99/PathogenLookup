using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PathogenLookup.Models
{
    public class PathogenType
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is a required field!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The {0} must be between {2} and {1} chars.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "URL is a required field!")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "The {0} must be between {2} and {1} and chars.")]
        public string URL { get; set; }
    }

    public class PathogenTypeDBContext : DbContext
    {
        public DbSet<PathogenType> PathogenTypes { get; set; }
        public List<PathogenType> PathogenTypeList { get; set; }
    }
}