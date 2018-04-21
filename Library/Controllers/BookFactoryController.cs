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
    public class BookFactoryController : ApiController
    {
        public IHttpActionResult Post(Book data)
        {
            var dbLibrary = new LibraryContext();
            dbLibrary.Books.Add(data);
            dbLibrary.SaveChanges();
            return Ok(data);
        }
    }
}
