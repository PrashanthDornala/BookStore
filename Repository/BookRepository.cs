using BookstorewithcoreMVC.Models;

namespace BookstorewithcoreMVC.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string Title, string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) && x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel> {
                new BookModel() { Id = 1, Title = "JAVA", Author = "Prasanth", Description="This is the description for JAVA book", Category="Programming", TotlaPages=1200, Langauge="English" },
                new BookModel() { Id = 2, Title = "MVC", Author = "Janson", Description="This is the description for MVC book", Category="Programming", TotlaPages=1500, Langauge="English"   },
                new BookModel() {Id = 3, Title = "C#", Author = "Jagan", Description = "This is the description for C# book", Category = "Programming", TotlaPages = 1000, Langauge = "English"},
                new BookModel() {Id = 4, Title = "Python", Author = "Suresh", Description = "This is the description for Python book", Category = "Programming", TotlaPages = 900, Langauge = "English"},
                new BookModel() {Id = 5, Title = "Angular", Author = "Naveen", Description = "This is the description for Angular book", Category = "Programming", TotlaPages = 1200, Langauge = "English"},
                new BookModel() {Id = 6, Title = "JavaScript", Author = "Prasanth", Description = "This is the description for JavaScript book", Category = "Programming", TotlaPages = 2000, Langauge = "English"}
            };
        }



    }
}
