using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisach
{
   
    public class Book
    {
        private int bookID;
        public int BookID
        {
            get { return this.bookID; }
            set { this.bookID = value; }
        }

        private string bookName;
        public string BookName
        {
            get { return this.bookName; }
            set { this.bookName = value; }
        }
        private string bookAuthor;
        public string BookAuthor
        {
            get { return this.bookAuthor; }
            set { this.bookAuthor = value; }
        }


        private string producer;
        public string Producer
        {
            get { return this.producer; }
            set { this.producer = value; }
        }


        private int yearPublishing;

        public int YearPublishing
        {
            get { return this.yearPublishing; }
            set { this.yearPublishing = value; }
        }
        private float price { get; set; }

        public float Price
        {
            get { return this.price; }
            set{ this.price = value; }
        }
        

        public Book()
        {

        }

        public Book(int bookID, string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.producer = producer;
            this.yearPublishing = yearPublishing;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ID cua sach: ");
            bookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of book: ");
            bookName = Console.ReadLine();

            Console.WriteLine("Enter the name of Author: ");
            bookAuthor = Console.ReadLine();

            Console.WriteLine("Enter the name of Producer: ");
            producer = Console.ReadLine();

            Console.WriteLine("Enter Year Publishing: ");
            yearPublishing = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Price: ");
            price = float.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("_________________BOOK INFORMATION ______________");
            Console.WriteLine("ID: " + bookID);
            Console.WriteLine("Name of Book: " + bookName);
            Console.WriteLine("Author: " + bookAuthor);
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Year Publishing: " + yearPublishing);
            Console.WriteLine("Price: " + price);
        }
    }
}
