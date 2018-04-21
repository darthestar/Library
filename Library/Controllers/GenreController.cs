using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Library.Models;
using Library.Data;

namespace Library.Controllers
{
    public class GenreController : ApiController
    {

        public IEnumerable<Genre> Get()
        {
            var dbLibraryContext = new LibraryContext();
            return dbLibraryContext.Genres.ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newGenre = new Genre
            {
                DisplayName = name
            };
            var dbLibraryContext = new LibraryContext();
            dbLibraryContext.Genres.Add(newGenre);
            dbLibraryContext.SaveChanges();
            return Ok(newGenre);
        }
    }
}
