using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Library.Data;
using Library.Models;
using System.Data.Entity;


namespace Library.Controllers
{
    public class BookController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            var dbLibrary = new LibraryContext();
            var data = dbLibrary.Books.Include(i => i.Author).Include(i => i.Genre);
            return data.ToList();
        }
    }
}
