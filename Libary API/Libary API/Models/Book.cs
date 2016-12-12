using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libary_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? YearPublish { get; set; }
        public bool? IsCheckedOut { get; set; }
        public DateTime? LastCheckOutDate { get; set; }
        public DateTime? DueBackDate { get; set; }
        
    }
}