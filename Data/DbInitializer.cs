using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryModel.Data;
using LibraryModel.Models;

namespace Avram_Maria_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return; // BD a fost creata anterior
            }
            var books = new Book[]
            {
 new Book{Title="Baltagul",Author="Mihail Sadoveanu",Price=Decimal.Parse("22")},
 new Book{Title="Enigma Otiliei",Author="George Calinescu",Price=Decimal.Parse("18")},
 new Book{Title="Maytrei",Author="Mircea Eliade",Price=Decimal.Parse("27")},
 new Book{Title="Panza de paianjen",Author="Cella Serghi",Price=Decimal.Parse("45")},
 new Book{Title="Fata de hartie",Author="Guillame Musso",Price=Decimal.Parse("38")},
 new Book{Title="De veghe in lanul de secara",Author="J.D. Salinger",Price=Decimal.Parse("28")},
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

 new Customer{CustomerID=1050,Name="Popescu Marcela",BirthDate=DateTime.Parse("1979-09-01")},
 new Customer{CustomerID=1045,Name="Mihailescu Cornel",BirthDate=DateTime.Parse("1969-07-08")},

            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();


            var publishers = new Publishers[]
            {
 new Publishers{ID=1,PublisherName="Humanitas",Adress="Str. Aviatorilor, nr. 40, Bucuresti"},
 new Publishers{ID=2,PublisherName="Nemira",Adress="Str. Plopilor, nr. 35, Ploiesti"},
 new Publishers{ID=3,PublisherName="Paralela 45",Adress="Str. Cascadelor, nr. 22, Cluj-Napoca"},
            };
            foreach (Publishers p in publishers)
            {
                context.Publishers.Add(p);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
 new Order{OrderID=500,CustomerID=1050,BookID=1,OrderDate=DateTime.Parse("2020-10-02")},
 new Order{OrderID=507,CustomerID=1045,BookID=3,OrderDate=DateTime.Parse("2020-09-28")},
 new Order{OrderID=545,CustomerID=1045,BookID=1,OrderDate=DateTime.Parse("2020-10-28")},
 new Order{OrderID=524,CustomerID=1050,BookID=2,OrderDate=DateTime.Parse("2020-09-28")},
 new Order{OrderID=530,CustomerID=1050,BookID=4,OrderDate=DateTime.Parse("2020-09-28")},
 new Order{OrderID=559,CustomerID=1050,BookID=6,OrderDate=DateTime.Parse("2020-10-28")},
 };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
            
            var publishedbooks = new PublishedBook[]
            {
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Humanitas").ID,
     BookID = books.Single(c => c.Title == "Maytrei" ).ID
},
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Humanitas").ID,
     BookID = books.Single(c => c.Title == "Enigma Otiliei" ).ID,

 },
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Nemira").ID,
     BookID = books.Single(c => c.Title == "Baltagul" ).ID
 },
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID,
     BookID = books.Single(c => c.Title == "Fata de hartie" ).ID
 },
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID,
     BookID = books.Single(c => c.Title == "Panza de paianjen" ).ID
 },
 new PublishedBook {
     PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID,
     BookID = books.Single(c => c.Title == "De veghe in lanul de secara" ).ID
 },
            };
            foreach (PublishedBook pb in publishedbooks)
            {
                context.PublishedBooks.Add(pb);
            }
            context.SaveChanges();
        }
    }
}
