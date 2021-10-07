using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Domain.Entities
{
    public class Director
    {
        public Guid Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public Guid CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

    }
}
