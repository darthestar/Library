using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Data;

namespace Library.Models
{
    public class Book
    {

        public int ID{get;set;}
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Condition { get; set; }
        public string ISBN { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? DueBackDate { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}