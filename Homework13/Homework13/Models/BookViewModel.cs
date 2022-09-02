
namespace Homework13.Models
{
    public class BookViewModel
    {
        public BookViewModel(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            Pages = pages;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}

