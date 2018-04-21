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
    public class AuthorController : ApiController
    {
        public IEnumerable<Author> Get()
        {
            var dbLibraryContext = new LibraryContext();
            return dbLibraryContext.Authors.ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newAuthor = new Author
            {
                Name = name
            };
            var dbLibraryContext = new LibraryContext();
            dbLibraryContext.Authors.Add(newAuthor);
            dbLibraryContext.SaveChanges();
            return Ok(newAuthor);
        }
        
    }
}
