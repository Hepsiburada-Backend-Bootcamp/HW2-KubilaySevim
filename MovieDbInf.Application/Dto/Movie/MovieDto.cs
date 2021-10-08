using System;

namespace MovieDbInf.Application.Dto.Movie
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }

        public Guid DirectorId { get; set; }
        public Guid GenreId { get; set; }
        public Guid CountryId { get; set; }
    }
}
