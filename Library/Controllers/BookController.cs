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
    public class BookController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            var dbLibrary = new LibraryContext();
            return dbLibrary.Books.ToList();
        }
    }
}
