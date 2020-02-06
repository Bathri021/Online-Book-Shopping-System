using Online_Book_Shopping_System.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Book_Shopping_System.Entity.Books
{
    public class Book
    {
        public Dictionary<int, Book> BookList = new Dictionary<int, Book>();

        public int BookID;
        public int UserID;
        public string Title;
        public string Author;
        public string Genere;
        public int Price;
        public int NoOfPages;
        public int Discount;

        public bool getBook(string title, string author, string genere, int price, int noOfPages)
        {
            Book book = new Book
            {
                // SellerID=
                Title = title,
                Author = author,
                Genere = genere,
                Price = price,
                NoOfPages = noOfPages
            };

            BookRepositary bookRepos = new BookRepositary();

            if (bookRepos.addBook(book) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}