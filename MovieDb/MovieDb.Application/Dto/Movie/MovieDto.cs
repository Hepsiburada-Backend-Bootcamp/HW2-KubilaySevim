using MovieDbInf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Application.Movie
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }

    }
}
