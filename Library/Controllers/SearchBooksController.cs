using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Library.ViewModels;
using Library.Models;
using Library.Data;

namespace Library.Controllers
{
    public class SearchBooksController : ApiController
    {
        [HttpGet]
        public IEnumerable<Book> Search([FromUri]SearchParams param)
        {
            using (var dbLibrary = new Data.LibraryContext())
            {
                var aquery = dbLibrary.Books.Include(i => i.Author).Include(i => i.Genre);

                if (!String.IsNullOrEmpty(param.Title))
                {
                    aquery = aquery.Where(w => w.Title == param.Title);
                }

                if (param.Author != null)
                {
                    aquery = aquery.Where (w => w.Author.Name == param.Author);
                }
                if (param.Genre != null)
                {
                    aquery = aquery.Where(w => w.Genre.DisplayName == param.Genre);
                }

                return aquery.ToList();
            }
        }
    }
}



