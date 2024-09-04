using linq_join.Models;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Yazarlar listesi
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" }
        };

        // Kitaplar listesi
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
        };

        // LINQ sorgusu ile kitapları ve yazarları birleştir
        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId
                    select new
                    {
                        BookTitle = book.Title,
                        AuthorName = author.Name
                    };

        // Sonuçları ekrana yazdır
        Console.WriteLine("Kitaplar ve Yazarları:");
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
        }
    }
}
