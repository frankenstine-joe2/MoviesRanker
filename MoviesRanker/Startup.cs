using AutoMapper;
using Microsoft.Owin;
using MoviesRanker.Models;
using MoviesRanker.ViewModels;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRanker.Startup))]
namespace MoviesRanker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Movie, MovieVM>();
                cfg.CreateMap<MovieVM, Movie>();
            });
        }
    }
}
