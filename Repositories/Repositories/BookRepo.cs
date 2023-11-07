using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BookRepo
    {
        private BookManagement2023DbContext context = new();
        
        public List<Book> GetAll()
        {
            var list = context.Books.Include(x => x.BookCategory).ToList();
            return list;
        }

        public List<BookCategory> GetAllCategories()
        {
            var list = context.BookCategories.ToList();
            return list;
        }

        public void Delete(int id)
        {
            var existBook = context.Books.FirstOrDefault(x => x.BookId == id);
            if(existBook != null)
            {
                context.Books.Remove(existBook);
            }
        }

        public void Add(Book book)
        {
            context.Books.Add(book);
        }

        public void Update(Book book)
        {
            var existingBook = context.Books.FirstOrDefault(x => x.BookId == book.BookId);
            if(existingBook != null) { 
                existingBook.BookName = book.BookName;
                existingBook.ReleaseDate = book.ReleaseDate;
                existingBook.Description = book.Description;
                existingBook.Price = book.Price;
                existingBook.Quantity = book.Quantity;
            }
        }

        public List<Book> Search(string keyword)
        {
            //where keyword || cột mình thích
            //search keyword nằm trong 2 cột Name hoặc Address
            var result = context.Books.Include(x => x.BookCategory).Where(s => s.BookName.ToLower().Contains(keyword.ToLower()) ||
                                        s.Author.ToLower().Contains(keyword.ToLower())|| s.Description.ToLower().Contains(keyword.ToLower())).ToList();
            return result;
        }
    }
}
