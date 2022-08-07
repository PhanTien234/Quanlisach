using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisach
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            List<ComicBook> comicBook = new List<ComicBook>();
            int choose;
            do
            {
                ShowMenu();
                Nhaplai:
                Console.WriteLine("Enter your choice (1-6): ");
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Input(comicBook);
                        break;
                    case 2:
                        Display(comicBook);
                        break;
                    case 3:
                        SortByYear(comicBook);
                        break;
                    case 4:
                        SearchByName(comicBook);
                        break;
                    case 5:
                        SearchByAuthor(comicBook);
                        break;
                    case 6:
                        AddBook(comicBook);
                        break;
                    case 7:
                        RemoveBook(comicBook);
                        break;
                    case 8:
                        Console.WriteLine("You have exited!");
                        break;
                    default:
                        Console.WriteLine("Enter wrong! Please Enter Again Number (1-6) ");
                        goto Nhaplai;

                }

            } while (choose != 8);

        }
        static void ShowMenu()
        {
            Console.WriteLine(" ___________________________BOOK MANAGEMENT_______________________");
            Console.WriteLine("|1. Enter information of n books                                  |");
            Console.WriteLine("|2. Show all kinds of books                                       |");
            Console.WriteLine("|3. Sort book information in descending order by  year publishing.|");
            Console.WriteLine("|4. Search for books by name of book                              |");
            Console.WriteLine("|5. Search for books by name of author                            |");
            Console.WriteLine("|6. Add Books                                                     |");
            Console.WriteLine("|7. Remove Books                                                  |");
            Console.WriteLine("|8. Exit programming                                              |");
            Console.WriteLine(" _________________________________________________________________");
            

        }
        static void Input(List<ComicBook> comicBook)
        {
            Console.WriteLine("Enter the number of books to add: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                ComicBook book = new ComicBook();
                book.Input();
                comicBook.Add(book);
            }

            
        }
        static void Display(List<ComicBook> comicBook)
        {
           
            for (int i = 0; i < comicBook.Count; i++)
            {
                comicBook[i].Display();
            }
        }
        static void SortByYear(List<ComicBook> comicBook)
        {
            
            Console.WriteLine("Sort by des yearPublishing :");
            comicBook.Sort((p1, p2) => (p1.YearPublishing < p2.YearPublishing) ? 1 : -1);
            foreach (ComicBook i in comicBook)
            {
                i.Display();
            }

        }
        static void SearchByName(List<ComicBook> comicBook)
        {
            Console.WriteLine("Enter the name of the book you are looking for: ");
            string searchBook = Console.ReadLine();
            int kq = 0;
            if (kq == 0)
            {
                Console.WriteLine("No Result");
            }
            for (int i = 0; i < comicBook.Count; i++)
            {
                if (comicBook[i].BookName.Equals(searchBook))
                {
                    comicBook[i].Display();
                }
            }
        }
        static void SearchByAuthor(List<ComicBook> comicBook)
        {
            Console.WriteLine("Enter the Author's name of the book: ");
            string searchBook = Console.ReadLine();
            int kq = 0;
            if (kq == 0)
            {
                Console.WriteLine("No Result");
            }
            for (int i = 0; i < comicBook.Count; i++)
            {
                if (comicBook[i].BookAuthor.Equals(searchBook))
                {
                    comicBook[i].Display();
                }
            }
        }
        static void AddBook(List<ComicBook> comicBook)
        {
            Console.WriteLine("Enter the number of books you want to add: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ComicBook book = new ComicBook();
                book.Input();
                comicBook.Add(book);
            }

        }
        static void RemoveBook(List<ComicBook> comicBook)
        {
           
            Console.WriteLine("Ennter Name of Book you want to remove: ");
            string searching = Console.ReadLine();
            var count = 0;
            for(int i=0; i<comicBook.Count; i++)
            {
                if(comicBook[i].BookName.Equals(searching))
                {
                    count++;
                    comicBook.Remove(comicBook[i]);
                    Console.WriteLine("Remove successfully! ");

                }
            }
            if(count==0)
            {
                Console.WriteLine("Not founded!");
            }



        }


    }
}
