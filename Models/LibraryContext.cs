using Microsoft.EntityFrameworkCore;
namespace LibraryManagement.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // Seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
            new Book
            {
                BookId = 1,
                Title = "Inferno",
                Author = "Dante Alighieri",
                ISBN = "978-1234567890",
                PublishedDate = new DateTime(1992, 1, 1),
                IsAvailable = true,
                ImageUrl = "/Images/foto1.jpg"
            },
            new Book
            {
                BookId = 2,
                Title = "Agnes Grey",
                Author = "Anne Brontë",
                ISBN = "978-1234567891",
                PublishedDate = new DateTime(1992, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto2.jpg"
            },
            new Book
            {
                BookId = 3,
                Title = "Broken April",
                Author = "Ismail Kadare",
                ISBN = "978-1234567892",
                PublishedDate = new DateTime(1980, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto3.jpg"
            },
            new Book
            {
                BookId = 4,
                Title = "The Karamazov Brothers",
                Author = "Fyodor Dostoevsky",
                ISBN = "978-1234567893",
                PublishedDate = new DateTime(2000, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto4.jpg"
            },
            new Book
            {
                BookId = 5,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "978-1234567894",
                PublishedDate = new DateTime(1925, 4, 10),
                IsAvailable = true,
                ImageUrl = "/images/foto5.jpg"
            },
            new Book
            {
                BookId = 6,
                Title = "The Iliad",
                Author = "Homer",
                ISBN = "978-1234567895",
                PublishedDate = new DateTime(1990, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto6.jpg"
            },
            new Book
            {
                BookId = 7,
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ISBN = "978-1234567896",
                PublishedDate = new DateTime(1951, 7, 16),
                IsAvailable = true,
                ImageUrl = "/images/foto7.jpg"
            },

            new Book
            {
                BookId = 8,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "978-1234567897",
                PublishedDate = new DateTime(1960, 7, 11),
                IsAvailable = true,
                ImageUrl = "/images/foto8.jpg"
            },
            new Book
            {
                BookId = 9,
                Title = "1984",
                Author = "George Orwell",
                ISBN = "978-1234567898",
                PublishedDate = new DateTime(1949, 6, 8),
                IsAvailable = true,
                ImageUrl = "/images/foto9.jpg"
            },
            new Book
            {
                BookId = 10,
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                ISBN = "978-1234567899",
                PublishedDate = new DateTime(1988, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto10.jpg"
            },
            new Book
            {
                BookId = 11,
                Title = "Crime and Punishment",
                Author = "Fyodor Dostoevsky",
                ISBN = "978-1234567800",
                PublishedDate = new DateTime(1866, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto11.jpg"
            },
            new Book
            {
                BookId = 12,
                Title = "Mother Teresa: Her Life Story",
                Author = "Navin Chawla",
                ISBN = "978-1234567801",
                PublishedDate = new DateTime(1992, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto12.jpg"
            },
            new Book
            {
                BookId = 13,
                Title = "The Hunger Games",
                Author = "Suzanne Collins",
                ISBN = "978-1234567802",
                PublishedDate = new DateTime(2008, 9, 14),
                IsAvailable = true,
                ImageUrl = "/images/foto13.jpg"
            },
            new Book
            {
                BookId = 14,
                Title = "The Castle",
                Author = "Ismail Kadare",
                ISBN = "978-1234567803",
                PublishedDate = new DateTime(1969, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto14.jpg"
            },
            new Book
            {
                BookId = 15,
                Title = "The Palace of Dreams",
                Author = "Ismail Kadare",
                ISBN = "978-1234567804",
                PublishedDate = new DateTime(1990, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto15.jpg"
            },
            new Book
            {
                BookId = 16,
                Title = "The Rose in the Glass",
                Author = "Dritëro Agolli",
                ISBN = "978-1234567805",
                PublishedDate = new DateTime(1998, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto16.jpg"
            },

            new Book
            {
                BookId = 17,
                Title = "Fourth Wing",
                Author = "Rebecca Yarros",
                ISBN = "978-1234567817",
                PublishedDate = new DateTime(2023, 1, 1),
                IsAvailable = true,
                ImageUrl = "/images/foto17.jpg"
            },
        new Book
        {
            BookId = 18,
            Title = "Jane Eyre",
            Author = "Charlotte Brontë",
            ISBN = "978-1234567818",
            PublishedDate = new DateTime(1847, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto18.jpg"
        },
        new Book
        {
            BookId = 19,
            Title = "Romeo and Juliet",
            Author = "William Shakespeare",
            ISBN = "978-1234567819",
            PublishedDate = new DateTime(1597, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto19.jpg"
        },
        new Book
        {
            BookId = 20,
            Title = "Cattle and Agriculture",
            Author = "Naim Frashëri",
            ISBN = "978-1234567820",
            PublishedDate = new DateTime(1900, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto20.jpg"
        },
        new Book
        {
            BookId = 21,
            Title = "Madame Bovary",
            Author = "Gustave Flaubert",
            ISBN = "978-1234567821",
            PublishedDate = new DateTime(1857, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto21.jpg"
        },
        new Book
        {
            BookId = 22,
            Title = "Frankenstein",
            Author = "Mary Shelley",
            ISBN = "978-1234567822",
            PublishedDate = new DateTime(1818, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto22.jpg"
        },
        new Book
        {
            BookId = 23,
            Title = "The Picture of Dorian Gray",
            Author = "Oscar Wilde",
            ISBN = "978-1234567823",
            PublishedDate = new DateTime(1890, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto23.jpg"
        },
        new Book
        {
            BookId = 24,
            Title = "The Odyssey",
            Author = "Homer",
            ISBN = "978-1234567824",
            PublishedDate = new DateTime(1800, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto24.jpg"
        },
        new Book
        {
            BookId = 25,
            Title = "Theogony",
            Author = "Hesiod",
            ISBN = "978-1234567825",
            PublishedDate = new DateTime(1760, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto25.jpg"
        },
        new Book
        {
            BookId = 26,
            Title = "Metamorphoses",
            Author = "Ovid",
            ISBN = "978-1234567826",
            PublishedDate = new DateTime(1800, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto26.jpg"
        },
        new Book
        {
            BookId = 27,
            Title = "The Library of Greek Mythology",
            Author = "Apollodorus",
            ISBN = "978-1234567827",
            PublishedDate = new DateTime(1780, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto27.jpg"
        },
        new Book
        {
            BookId = 28,
            Title = "The Complete Greek Tragedies",
            Author = "Sophocles, Euripides, Aeschylus",
            ISBN = "978-1234567828",
            PublishedDate = new DateTime(1900, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto28.jpg"
        },
        new Book
        {
            BookId = 29,
            Title = "One Hundred Years of Solitude",
            Author = "Gabriel García Márquez",
            ISBN = "978-1234567829",
            PublishedDate = new DateTime(1967, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto29.jpg"
        },
        new Book
        {
            BookId = 30,
            Title = "Being and Nothingness",
            Author = "Jean-Paul Sartre",
            ISBN = "978-1234567830",
            PublishedDate = new DateTime(1943, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto30.jpg"
        },

        new Book
        {
            BookId = 31,
            Title = "Dracula",
            Author = "Bram Stoker",
            ISBN = "978-1234567831",
            PublishedDate = new DateTime(1897, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto31.jpg"
        },
        new Book
        {
            BookId = 32,
            Title = "The Lord of the Rings",
            Author = "J.R.R. Tolkien",
            ISBN = "978-1234567832",
            PublishedDate = new DateTime(1954, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto32.jpg"
        },
        new Book
        {
            BookId = 33,
            Title = "The Three-Body Problem",
            Author = "Cixin Liu",
            ISBN = "978-1234567833",
            PublishedDate = new DateTime(2017, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto33.jpg"
        },
        new Book
        {
            BookId = 34,
            Title = "The Prince",
            Author = "Niccolò Machiavelli",
            ISBN = "978-1234567834",
            PublishedDate = new DateTime(1513, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto34.jpg"
        },

        new Book
        {
            BookId = 35,
            Title = "The Little Prince",
            Author = "Antoine de Saint-Exupéry",
            ISBN = "978-1234567835",
            PublishedDate = new DateTime(2017, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto35.jpg"
        },
        new Book
        {
            BookId = 36,
            Title = "Hamlet",
            Author = "William Shakespeare",
            ISBN = "978-1234567836",
            PublishedDate = new DateTime(2005, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto36.jpg"
        },
        new Book
        {
            BookId = 37,
            Title = "Meri Yll",
            Author = "Viktor Canosinaj",
            ISBN = "978-1234567837",
            PublishedDate = new DateTime(2006, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto37.jpg"
        },
        new Book
        {
            BookId = 38,
            Title = "Harry Potter and the Philosopher's Stone",
            Author = "J.K. Rowling",
            ISBN = "978-1234567838",
            PublishedDate = new DateTime(2000, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto38.jpg"
        },
        new Book
        {
            BookId = 39,
            Title = "Harry Potter and the Chamber of Secrets",
            Author = "J.K. Rowling",
            ISBN = "978-1234567839",
            PublishedDate = new DateTime(2001, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto39.jpg"
        },
        new Book
        {
            BookId = 40,
            Title = "Harry Potter and the Prisoner of Azkaban",
            Author = "J.K. Rowling",
            ISBN = "978-1234567840",
            PublishedDate = new DateTime(2002, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto40.jpg"
        },
        new Book
        {
            BookId = 41,
            Title = "Harry Potter and the Goblet of Fire",
            Author = "J.K. Rowling",
            ISBN = "978-1234567841",
            PublishedDate = new DateTime(2003, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto41.jpg"
        },
        new Book
        {
            BookId = 42,
            Title = "Harry Potter and the Order of the Phoenix",
            Author = "J.K. Rowling",
            ISBN = "978-1234567842",
            PublishedDate = new DateTime(2004, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto42.jpg"
        },
        new Book
        {
            BookId = 43,
            Title = "Harry Potter and the Half-Blood Prince",
            Author = "J.K. Rowling",
            ISBN = "978-1234567843",
            PublishedDate = new DateTime(2005, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto43.jpg"
        },
        new Book
        {
            BookId = 44,
            Title = "Harry Potter and the Deathly Hallows",
            Author = "J.K. Rowling",
            ISBN = "978-1234567844",
            PublishedDate = new DateTime(2007, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto44.jpg"
        },
        new Book
        {
            BookId = 45,
            Title = "The Failure",
            Author = "Dritëro Agolli",
            ISBN = "978-1234567845",
            PublishedDate = new DateTime(1970, 1, 1),
            IsAvailable = true,
            ImageUrl = "/images/foto45.jpg"
        }


            );

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }
    }
}

