using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                    c => c.Id,
                    b => b.CategoryId,
                    (c, books) => new { Category = c.Name, Books = books });
            foreach (var group in groups)
            {
                Console.WriteLine(group.Category);
                foreach (var book in group.Books)
                {
                    Console.WriteLine($" {book.Title} ({book.PublishedYear} 年)");
                }
            }
        }
    }
}