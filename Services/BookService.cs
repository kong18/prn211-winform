using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookManagement2023DbContext context = new();
        
        BookRepo repo = new();

        public List<Book> getAllBooks()
        {
            var books = repo.GetAll();
            return books;
        }

        public void DeleteBook(string id)
        {
            var existBook = context.Books.FirstOrDefault(x => x.BookId.ToString().Equals(id));
            if(existBook != null)
            { 
                context.Books.Remove(existBook);
                context.SaveChanges();
            }
        }

        public List<Book> searchByName(string keyword)
        {
            List<Book> list = repo.Search(keyword);
            return list;
        }

        public void AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public bool IsIdDuplicated(int id)
        {
            return context.Books.Any(s => s.BookId == id);
        }
    }
}
