using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using moviesAPI.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace moviesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesContext _context;

        public MoviesController(MoviesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Movies>> Get()
        {
            List<Movies> movieList = await _context.Movies.ToListAsync();
            return movieList;
        }

        [HttpGet("{id}")]
        public async Task<Movies> Get(int id)
        {
            Movies chosenMovie = await _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);
            return chosenMovie;
        }

        [HttpGet("{firstname}")]
        public async Task<IEnumerable<Movies>> Get(string title)
        {
            List<Movies> movieList = await _context.Movies
            .Where(movie => movie.Title.ToLower()
           .Contains(title.ToLower()))
            .ToListAsync();
            return movieList;
        }



    }

}