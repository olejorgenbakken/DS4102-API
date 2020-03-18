using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System.Collections.Generic;
using System;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        List<Movie> MovieList = new List<Movie> {
            new Movie {
                Id = 1000,
                Title = "The Lighthouse",
                ReleaseDate = new DateTime(2020, 2, 24),
                Img = "https://images-na.ssl-images-amazon.com/images/I/71PvdrX85TL._AC_SL1500_.jpg"
            }, new Movie {
                Id = 1001,
                Title = "Saint Maud",
                ReleaseDate = new DateTime(2020, 4, 3),
                Img = "https://cdn.collider.com/wp-content/uploads/2020/02/saint-maud-poster-405x600.jpeg"
            }, new Movie {
                Id = 1002,
                Title = "Midsommar",
                ReleaseDate = new DateTime(2019, 6, 18),
                Img = "https://m.media-amazon.com/images/M/MV5BMzQxNzQzOTQwM15BMl5BanBnXkFtZTgwMDQ2NTcwODM@._V1_UY1200_CR90,0,630,1200_AL_.jpg"
            }, new Movie {
                Id = 1003,
                Title = "In Fabric",
                ReleaseDate = new DateTime(2018, 9, 13),
                Img = "https://m.media-amazon.com/images/M/MV5BMmY5YzZjMjQtMjc2NS00ZDU2LTk4MTgtZDgwZmRmM2VlZTVmXkEyXkFqcGdeQXVyMTAzNjk5MDI4._V1_UY1200_CR92,0,630,1200_AL_.jpg"
            }, new Movie {
                Id = 1004,
                Title = "Uncut Gems",
                ReleaseDate = new DateTime(2019, 8, 30),
                Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.com%2FPoster-Quality-Limited-Sandler-Garnett%2Fdp%2FB082P9JTN8&psig=AOvVaw1o-F-LB9SDf4vMpbCF4Ngx&ust=1583588320284000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMC0_6z8hegCFQAAAAAdAAAAABAD"
            }
        };

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            Movie chosenMovie = MovieList.Find(movie => movie.Id == id);

            return chosenMovie;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return MovieList;
        }
    }
}