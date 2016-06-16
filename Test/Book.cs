using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    public class Book
    {
        public Book(int bookId,string bookTitle,string bookContent)
        {
            Id = bookId;
            Title = bookTitle;
            Content = bookContent;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}