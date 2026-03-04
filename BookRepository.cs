using NOA_Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace NOA_Library.Repositories
{
    public class BookRepository
    {
        private static readonly List<Books> books = new List<Books>
        {
            new Books {
    Id = 1,
    Title = "Inferno",
    Author = "Dante Alighieri",
    Publisher = "Wordsworth Classics",
    Year = "1992",
    Pages = 432,
    Language = "English",
    Genre = "Epic Poetry",
    ImageUrl = "/images/foto1.jpg",
    Description = "\"Inferno\" is the first part of Dante Alighieri's \"Divine Comedy,\" which describes the poet's journey through Hell, where he meets the souls of the damned and experiences the consequences of their sins. This book is an English translation of the classic work and offers a deep insight into medieval philosophy and theology."
},
new Books {
    Id = 2,
    Title = "Agnes Grey",
    Author = "Anne Brontë",
    Publisher = "Wordsworth Classics",
    Year = "1992",
    Pages = 320,
    Language = "English",
    Genre = "Classic Novel",
    ImageUrl = "/images/foto2.jpg",
    Description = "\"Agnes Grey\" is a novel by Anne Brontë that tells the story of a young governess, Agnes, and her experiences with the aristocratic families she serves. The book offers a critique of Victorian society and the role of women at that time."
},
new Books {
    Id = 3,
    Title = "Broken April",
    Author = "Ismail Kadare",
    Publisher = "Dituria",
    Year = "1980",
    Pages = 232,
    Language = "Albanian",
    Genre = "Historical Novel",
    ImageUrl = "/images/foto3.jpg",
    Description = "\"Broken April\" is a novel by the renowned Albanian author Ismail Kadare. This book addresses themes of revenge and the code of honor in the mountainous regions of Albania. The story follows the life of Gjorg Berisha, a young man who must fulfill a revenge according to the Kanun of Lekë Dukagjini, an ancient customary code."
},
new Books {
    Id = 4,
    Title = "The Karamazov Brothers",
    Author = "Fyodor Dostoevsky",
    Publisher = "Dituria",
    Year = "2000",
    Pages = 800,
    Language = "Albanian",
    Genre = "Philosophical Novel",
    ImageUrl = "/images/foto4.jpg",
    Description = "This novel by Fyodor Dostoevsky is one of the most famous works of Russian literature, dealing with themes of morality, faith, and human nature through the story of three brothers and their corrupt father."
},
new Books {
    Id = 5,
    Title = "The Great Gatsby",
    Author = "F. Scott Fitzgerald",
    Publisher = "Charles Scribner's Sons",
    Year = "1925",
    Pages = 180,
    Language = "English",
    Genre = "Classic Novel, Tragedy, Romanticism",
    ImageUrl = "/images/foto5.jpg",
    Description = "This novel is a portrayal of American society in the post-World War I era, exploring passion, betrayal, and illusions of success in a period filled with luxury and destruction."
},
new Books {
    Id = 6,
    Title = "The Iliad",
    Author = "Homer",
    Publisher = "N/A",
    Year = "8th century BC",
    Pages = 500,
    Language = "Ancient Greek",
    Genre = "Epic, Mythology",
    ImageUrl = "/images/foto6.jpg",
    Description = "\"The Iliad\" is one of the most well-known and important works of Greek literature. It describes the events of the Trojan War, focusing on the wrath of the hero Achilles and its impact on the battle. This epic is a reflection of Greek mythology and war, society, and honor."
},
new Books {
    Id = 7,
    Title = "The Catcher in the Rye",
    Author = "J.D. Salinger",
    Publisher = "Little, Brown and Company",
    Year = "1951",
    Pages = 214,
    Language = "English",
    Genre = "Drama",
    ImageUrl = "/images/foto7.jpg",
    Description = "This novel tells the story of Holden Caulfield, a young man who struggles with the uncertainties of life and the loss of innocence. The story speaks of the difficult details of adolescence and rebellion against social norms."
},
new Books {
    Id = 8,
    Title = "To Kill a Mockingbird",
    Author = "Harper Lee",
    Publisher = "J.B. Lippincott & Co.",
    Year = "1960",
    Pages = 281,
    Language = "English",
    Genre = "Historical Novel, Drama, Tragedy",
    ImageUrl = "/images/foto8.jpg",
    Description = "This novel describes racism and injustice in a small town in the southern United States during the Great Depression. The story follows the coming-of-age of a young girl, Scout Finch, and her father's battle to defend an innocent man accused of rape simply because of his skin color."
},
new Books {
    Id = 9,
    Title = "1984",
    Author = "George Orwell",
    Publisher = "Secker & Warburg",
    Year = "1949",
    Pages = 328,
    Language = "English",
    Genre = "Dystopian, Sci-Fi, Political",
    ImageUrl = "/images/foto9.jpg",
    Description = "This novel is a strong critique of totalitarianism and state control. In a suppressed and surveilled world, Winston Smith struggles to resist a totalitarian regime that controls every individual's mind."
},
new Books {
    Id = 10,
    Title = "The Alchemist",
    Author = "Paulo Coelho",
    Publisher = "HarperCollins",
    Year = "1988",
    Pages = 208,
    Language = "English",
    Genre = "Philosophical, Adventure, Motivational",
    ImageUrl = "/images/foto10.jpg",
    Description = "This novel tells the story of Santiago, a young boy who travels the world in search of treasure, experiencing a spiritual journey. The book is a reflection on the pursuit of dreams and the meaning of life."
},
new Books {
    Id = 11,
    Title = "Crime and Punishment",
    Author = "Fyodor Dostoevsky",
    Publisher = "Dituria",
    Year = "1866",
    Pages = 400,
    Language = "Albanian",
    Genre = "Philosophical, Psychological",
    ImageUrl = "/images/foto11.jpg",
    Description = "This is one of Dostoevsky's most famous novels, exploring the conscience and morality of a poor student, Raskolnikov, who commits a murder and experiences its psychological consequences."
},
new Books {
    Id = 12,
    Title = "Mother Teresa: Her Life Story",
    Author = "Navin Chawla",
    Publisher = "Tyndale House",
    Year = "1992",
    Pages = 328,
    Language = "English",
    Genre = "Biography",
    ImageUrl = "/images/foto12.jpg",
    Description = "This biography of Mother Teresa reflects her extraordinary life as a humanitarian and her tireless work helping the poor and sick in India and around the world."
},
new Books {
    Id = 13,
    Title = "The Hunger Games",
    Author = "Suzanne Collins",
    Publisher = "Scholastic Press",
    Year = "2008",
    Pages = 374,
    Language = "English",
    Genre = "Sci-Fi, Dystopian, Adventure",
    ImageUrl = "/images/foto13.jpg",
    Description = "This novel is the story of a destroyed world where young people are forced to fight in a life-or-death game representing the reality of an oppressed society. This is the first book of the trilogy, known for its critique of power and control."
},
new Books {
    Id = 14,
    Title = "The Castle",
    Author = "Ismail Kadare",
    Publisher = "Dituria",
    Year = "1969",
    Pages = 220,
    Language = "Albanian",
    Genre = "Historical Novel",
    ImageUrl = "/images/foto14.jpg",
    Description = "This novel is a portrayal of Albanian society and the struggle for power during the Ottoman period. The history depicted through characters and dramatic events explores deep themes of the individual against the state and injustice."
},
new Books {
    Id = 15,
    Title = "The Palace of Dreams",
    Author = "Ismail Kadare",
    Publisher = "Dituria",
    Year = "1990",
    Pages = 320,
    Language = "Albanian",
    Genre = "Philosophical",
    ImageUrl = "/images/foto15.jpg",
    Description = "This novel is a critique of totalitarian society and how individuals are involved in a rigid, rewardless system for their help. It appears as a reflection on the lives of invisible people, trapped in a bureaucratic system."
},
new Books {
    Id = 16,
    Title = "The Rose in the Glass",
    Author = "Dritëro Agolli",
    Publisher = "Dituria",
    Year = "1998",
    Pages = 230,
    Language = "Albanian",
    Genre = "Modern Novel, Romantic",
    ImageUrl = "/images/foto16.jpg",
    Description = "This novel is a love story set in the post-war period and deals with the complexities of love, society, and politics. It is a reflection of daily life and the feelings that clash with the challenges of the time."
},
new Books {
    Id = 17,
    Title = "Fourth Wing",
    Author = "Rebecca Yarros",
    Publisher = "Entangled: Red Tower Books",
    Year = "2023",
    Pages = 512,
    Language = "English",
    Genre = "Fantasy, Adventure",
    ImageUrl = "/images/foto17.jpg",
    Description = "This fantasy novel follows the story of a girl recruited into an elite dragon-fighting unit. She must develop her skills to survive and protect her country from great threats. With elements of action and romance, the novel has captured the attention of readers worldwide."
},
new Books {
    Id = 18,
    Title = "Jane Eyre",
    Author = "Charlotte Brontë",
    Publisher = "Smith, Elder & Co.",
    Year = "1847",
    Pages = 500,
    Language = "English",
    Genre = "Classic, Gothic",
    ImageUrl = "/images/foto18.jpg",
    Description = "This novel follows the life of the orphaned Jane Eyre, her struggle for independence, and her experiences with love, religion, and society. The book is noted for its strong, independent female protagonist and its critique of social norms."
},
new Books {
    Id = 19,
    Title = "Romeo and Juliet",
    Author = "William Shakespeare",
    Publisher = "N/A",
    Year = "1597",
    Pages = 200,
    Language = "English",
    Genre = "Tragedy, Romance",
    ImageUrl = "/images/foto19.jpg",
    Description = "This is one of Shakespeare's most famous plays, centered around the tragic love story of Romeo and Juliet. The play deals with themes of fate, family loyalty, and the consequences of hatred between two families."
},
new Books {
    Id = 20,
    Title = "Cattle and Agriculture",
    Author = "Naim Frashëri",
    Publisher = "Dituria",
    Year = "1900",
    Pages = 150,
    Language = "Albanian",
    Genre = "Poetry, Philosophy",
    ImageUrl = "/images/foto20.jpg",
    Description = "This is a poetic reflection on Albanian rural life, focusing on agriculture and its significance in the cultural and social life of Albania. It also speaks to the nation's spirit and its close relationship to nature."
},
new Books {
    Id = 21,
    Title = "Madame Bovary",
    Author = "Gustave Flaubert",
    Publisher = "Michel Lévy Frères",
    Year = "1857",
    Pages = 400,
    Language = "French",
    Genre = "Realism, Novel",
    ImageUrl = "/images/foto21.jpg",
    Description = "This is the story of Emma Bovary, a woman trapped in an unsatisfying marriage who dreams of a life of luxury and passion. The novel critiques bourgeois society, the constraints of marriage, and the realities of life."
},
new Books {
    Id = 22,
    Title = "Frankenstein",
    Author = "Mary Shelley",
    Publisher = "Lackington, Hughes, Harding, Mavor & Jones",
    Year = "1818",
    Pages = 280,
    Language = "English",
    Genre = "Gothic, Sci-Fi, Horror",
    ImageUrl = "/images/foto22.jpg",
    Description = "This novel tells the story of Victor Frankenstein, a scientist who creates a monster. The book explores themes of hubris, morality, and the consequences of playing god."
},
new Books {
    Id = 23,
    Title = "The Picture of Dorian Gray",
    Author = "Oscar Wilde",
    Publisher = "Ward, Lock & Co.",
    Year = "1890",
    Pages = 250,
    Language = "English",
    Genre = "Philosophical Fiction, Gothic",
    ImageUrl = "/images/foto23.jpg",
    Description = "The novel tells the story of Dorian Gray, a man whose portrait ages while he remains youthful. It explores themes of beauty, morality, and the dangers of a life without responsibility."
},
new Books {
    Id = 24,
    Title = "The Odyssey",
    Author = "Homer",
    Publisher = "N/A",
    Year = "8th century BC",
    Pages = 400,
    Language = "Ancient Greek",
    Genre = "Epic Poetry",
    ImageUrl = "/images/foto24.jpg",
    Description = "\"The Odyssey\" is a continuation of Homer's \"Iliad.\" It focuses on Odysseus' long journey home from the Trojan War, filled with adventures and challenges. It remains one of the most important works in Western literature."
},
new Books {
    Id = 25,
    Title = "Theogony",
    Author = "Hesiod",
    Publisher = "N/A",
    Year = "700 BC",
    Pages = 100,
    Language = "Ancient Greek (translated into various languages)",
    Genre = "Mythology, Poetry",
    ImageUrl = "/images/foto25.jpg",
    Description = "This book is one of the primary sources of Greek mythology. It describes the creation of the world and the first gods, as well as the development of the hierarchy of the Olympian gods. 'Theogony' is a fundamental text that presents legends about the origin and birth of various Greek gods."
},
new Books {
    Id = 26,
    Title = "Metamorphoses",
    Author = "Ovid",
    Publisher = "N/A",
    Year = "8 AD",
    Pages = 500,
    Language = "Latin (translated into various languages)",
    Genre = "Epic, Mythology",
    ImageUrl = "/images/foto26.jpg",
    Description = "This book is a collection of Roman and Greek mythology, written by the Roman poet Ovid. It contains a collection of mythological legends that describe the transformation of people, gods, and natural elements. It is one of the most famous works of classical literature and includes more than 250 myths."
},
new Books {
    Id = 27,
    Title = "The Library of Greek Mythology",
    Author = "Apollodorus",
    Publisher = "N/A",
    Year = "1st century AD",
    Pages = 475,
    Language = "Ancient Greek (translated into various languages)",
    Genre = "Mythology",
    ImageUrl = "/images/foto27.jpg",
    Description = "This book is a collection of mythological stories of the ancient Greeks, including tales about gods and heroes. It includes many of the main myths of Greek mythology, including those of Heracles, Perseus, and Jason."
},
new Books {
    Id = 28,
    Title = "The Complete Greek Tragedies",
    Author = "Sophocles, Euripides, Aeschylus",
    Publisher = "University of Chicago Press",
    Year = "0",
    Pages = 1500,
    Language = "English",
    Genre = "Tragedy, Mythology",
    ImageUrl = "/images/foto28.jpg",
    Description = "This collection contains the most famous tragedies of the ancient Greek playwrights, such as Sophocles, Euripides, and Aeschylus, including 'Oedipus Rex,' 'Medea,' and 'Prometheus Bound.' Each work presents themes of fate, gods, and human tragedies."
},
new Books {
    Id = 29,
    Title = "One Hundred Years of Solitude",
    Author = "Gabriel García Márquez",
    Publisher = "Editorial Sudamericana",
    Year = "1967",
    Pages = 417,
    Language = "Spanish",
    Genre = "Magical Realism, Novel",
    ImageUrl = "/images/foto29.jpg",
    Description = "This novel is one of the most famous works of magical realism, describing the events of a famous family, the Buendías, who live in an isolated town, Macondo."
},
new Books {
    Id = 30,
    Title = "Being and Nothingness",
    Author = "Jean-Paul Sartre",
    Publisher = "Gallimard",
    Year = "1943",
    Pages = 800,
    Language = "French",
    Genre = "Philosophy, Existentialism",
    ImageUrl = "/images/foto30.jpg",
    Description = "One of the most important works of existentialist philosophy, where Sartre addresses the nature of consciousness and how individuals create meaning in life."
},
new Books {
    Id = 31,
    Title = "Dracula",
    Author = "Bram Stoker",
    Publisher = "Archibald Constable & Co",
    Year = "1897",
    Pages = 400,
    Language = "English",
    Genre = "Gothic, Horror",
    ImageUrl = "/images/foto31.jpg",
    Description = "One of the most famous works of the gothic and horror genre that tells the story of Count Dracula and his attempts to conquer England."
},
new Books {
    Id = 32,
    Title = "The Lord of the Rings",
    Author = "J.R.R. Tolkien",
    Publisher = "George Allen & Unwin",
    Year = "1954",
    Pages = 1200,
    Language = "English",
    Genre = "Fantasy, Adventure",
    ImageUrl = "/images/foto32.jpg",
    Description = "An epic novel that follows Frodo Baggins' journey to destroy the One Ring, depicting the battle of good against evil."
},
new Books {
    Id = 33,
    Title = "The Three-Body Problem",
    Author = "Cixin Liu",
    Publisher = "Verlag der 3. Buchgesellschaft",
    Year = "2017",
    Pages = 400,
    Language = "German",
    Genre = "Science Fiction",
    ImageUrl = "/images/foto33.jpg",
    Description = "A science fiction novel that addresses humanity's attempts to communicate with an external civilization and the consequences that this brings."
},
new Books {
    Id = 34,
    Title = "The Prince",
    Author = "Niccolò Machiavelli",
    Publisher = "N/A",
    Year = "1513",
    Pages = 100,
    Language = "Italian",
    Genre = "Political, Philosophical",
    ImageUrl = "/images/foto34.jpg",
    Description = "One of the most important works of political science, offering practical advice to princes and leaders on how to gain and maintain power."
},
new Books {
    Id = 35,
    Title = "The Little Prince",
    Author = "Antoine de Saint-Exupéry",
    Publisher = "Dituria",
    Year = "2017",
    Pages = 104,
    Language = "Albanian",
    Genre = "Novel",
    ImageUrl = "/images/foto35.jpg",
    Description = "'The Little Prince' is a timeless story dedicated to all children: children of today, those who were once children, and those who will never stop being children."
},
new Books {
    Id = 36,
    Title = "Hamlet",
    Author = "William Shakespeare",
    Publisher = "Onufri",
    Year = "2005",
    Pages = 248,
    Language = "Albanian",
    Genre = "Tragedy",
    ImageUrl = "/images/foto36.jpg",
    Description = "'Hamlet' is one of the most famous works of William Shakespeare, describing the story of Prince Hamlet of Denmark and his attempts to avenge his father's murder by his uncle Claudius. The Albanian translation was done by Fan S. Noli."
},
new Books {
    Id = 37,
    Title = "Meri Yll",
    Author = "Viktor Canosinaj",
    Publisher = "Dyrrah",
    Year = "2006",
    Pages = 232,
    Language = "Albanian",
    Genre = "Novel",
    ImageUrl = "/images/foto37.jpg",
    Description = "'Meri Yll' is a novel that deals with social issues and reflects the life of a 13-year-old girl who loses her mother and faces significant challenges in her life."
},
new Books {
    Id = 38,
    Title = "Harry Potter and the Philosopher's Stone",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2000",
    Pages = 320,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto38.jpg",
    Description = "This is the first book in the 'Harry Potter' series, where Harry discovers that he is a wizard and embarks on his adventures at Hogwarts School of Witchcraft and Wizardry."
},
new Books {
    Id = 39,
    Title = "Harry Potter and the Chamber of Secrets",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2001",
    Pages = 352,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto39.jpg",
    Description = "In this book, Harry and his friends return to Hogwarts for their second school year. They discover the existence of the Chamber of Secrets and face mysterious events."
},
new Books {
    Id = 40,
    Title = "Harry Potter and the Prisoner of Azkaban",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2002",
    Pages = 448,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto40.jpg",
    Description = "Harry returns for his third year and learns about the escape of Sirius Black from Azkaban prison. He is confronted with his past and connections to this dangerous character."
},
new Books {
    Id = 41,
    Title = "Harry Potter and the Goblet of Fire",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2003",
    Pages = 608,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto41.jpg",
    Description = "Harry participates in the Triwizard Tournament and faces dangerous challenges that test his skills and courage."
},
new Books {
    Id = 42,
    Title = "Harry Potter and the Order of the Phoenix",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2004",
    Pages = 896,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto42.jpg",
    Description = "Harry creates the Order of the Phoenix to fight against the growing dark forces. He faces new challenges and great losses."
},
new Books {
    Id = 43,
    Title = "Harry Potter and the Half-Blood Prince",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2005",
    Pages = 672,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto43.jpg",
    Description = "Harry discovers more about Lord Voldemort's past and prepares for the final battle. He faces losses and betrayals that challenge his trust and strength."
},
new Books {
    Id = 44,
    Title = "Harry Potter and the Deathly Hallows",
    Author = "J.K. Rowling",
    Publisher = "Dituria",
    Year = "2007",
    Pages = 784,
    Language = "Albanian",
    Genre = "Fantasy",
    ImageUrl = "/images/foto44.jpg",
    Description = "Harry and his friends embark on a journey to destroy the Horcruxes and defeat Lord Voldemort. They face great dangers and sacrifices to save the magical world."
},
new Books {
    Id = 45,
    Title = "The Failure",
    Author = "Dritëro Agolli",
    Publisher = "Naim Frashëri",
    Year = "1970",
    Pages = 220,
    Language = "Albanian",
    Genre = "Novel",
    ImageUrl = "/images/foto45.jpg",
    Description = "'The Failure' is one of Dritëro Agolli's most important novels, dealing with themes of failure, self-reflection, and the challenges of an individual in a complex society. Through a deep narrative and the author's sensitivity, the novel explores the dilemma between personal success and the limitations of social reality."
}
        };
        public List<Books> GetAllBooks()
        {
            return books;
        }

        public Books GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Books> GetBooksByGenre(string genre)
        {
            return books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void AddRating(int bookId, Rating rating)
        {
            var book = GetBookById(bookId);
            if (book != null)
            {
                // Shto vlerësimin për librin
                book.Ratings.Add(rating);
                // Mund të shtoni kod për të ruajtur ndryshimet në bazën e të dhënave, nëse është e nevojshme
            }
        }


    }

}

