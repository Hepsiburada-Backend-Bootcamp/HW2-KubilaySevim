using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MovieDbInf.Infrastructure;
using Microsoft.Extensions.Configuration;
using MovieDbInf.Application.IServices;
using MovieDbInf.Application.Services;
using MovieDbInf.Application.Movie;

namespace MovieDbInf.Application
{
    public static class ApplicationModuleExtension
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddInfrastructureModule(configuration);


            services.AddScoped<IDirectorService, DirectorService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }
    }
}


