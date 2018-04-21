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
    public class AuthorFactoryController : ApiController
    {
        public IHttpActionResult Post(Author data)
        {
            var dbLibraryContext = new LibraryContext();
            dbLibraryContext.Authors.Add(data);
            dbLibraryContext.SaveChanges();
            return Ok(data);
        }
    }
}
