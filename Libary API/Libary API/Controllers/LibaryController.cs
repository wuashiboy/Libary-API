using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net;
using System.IO;
using System.Net.Http;
using Libary_API.Models;
using System.Data.SqlClient;
using Libary_API.Services;

namespace Libary_API.Controllers
{
    public class LibaryController : ApiController
    {
        private readonly object bookToUpdate;

        [HttpGet]
        public IHttpActionResult ReadFromBooks()
        {
            var Lib = new Libary();
            var rv = Lib.GetAllBook();
            return Ok(rv);
        }

        [HttpGet]
        public IHttpActionResult BookOut(bool IscheckedOut)
        {
            var Lib = new LibaryOut();
            var rv = Lib.booksOut(IscheckedOut);
            return Ok(rv);
        }

        [HttpGet]
        public IHttpActionResult BookAvail(bool NotcheckedOut)
        {
            var Lib = new LibaryAvail();
            var rv = Lib.booksAvail(NotcheckedOut);
            return Ok(rv);
        }

        public static List<Book> Addbooks { get; set; } = new List<Book>
        {
            new Book {Title= "The Boy in the Striped Pyjama", Author= "John Boyne", YearPublish= int.Parse("2006") },

        };

        [HttpPut]
        public Book AddNewBook(string title, string author, int? yearpublish)
        {
            var b = new Book {Title = title, Author = author, YearPublish = yearpublish };
            Addbooks.Add(b);
            return b;
        }

        //[HttpPost]
        //public IHttpActionResult UpdateBook(DateTime DueBackDate)
        //{
        //    var found = bookToUpdate.IsCheckedOut;
        //}
    }
            
}
 

    
