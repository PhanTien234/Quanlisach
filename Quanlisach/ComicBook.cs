using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisach
{
    public class ComicBook : Book
    {
        
        public string Language { get; set; }
        public string Semester { get; set; }

        public ComicBook() : base()
        {

        }
        public ComicBook(int bookID, string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, string semester)
            : base(bookID, bookName, bookAuthor, producer, yearPublishing, price)
        {
            this.Language = language;
            this.Semester = semester;

        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter the Language: ");
            Language = Console.ReadLine();
            Console.WriteLine("Enter the Semester: ");
            Semester =Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Semester: " + Semester);
        }
    }
}
