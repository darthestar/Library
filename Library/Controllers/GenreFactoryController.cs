using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Library.Data;
using Library.Models;

namespace Library.Controllers
{
    public class GenreFactoryController : ApiController
    {
        public IHttpActionResult Post(Genre data)
        {
            var dbLibraryContext = new LibraryContext();
            dbLibraryContext.Genres.Add(data);
            dbLibraryContext.SaveChanges();
            return Ok(data);
        }
    }
}
