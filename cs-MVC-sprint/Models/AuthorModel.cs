using System.Text.Json;

namespace cs_MVC_sprint.Models
{
    public interface IAuthorModel
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
    }
    public class AuthorModel : IAuthorModel
    {
        public List<Author> GetAllAuthors()
        {
            var filepath = "Resources/Authors.json";
            var json = File.ReadAllText(filepath);
            List<Author>? authors = JsonSerializer.Deserialize<List<Author>>(json);

            return authors.Select(author => new Author
            {
                Id = author.Id,
                Name = author.Name,
                Nationality = author.Nationality
            }).ToList();

        }
        public Author GetAuthorById( int id)
        {
            var filepath = "Resources/Authors.json";
            var json = File.ReadAllText(filepath);
            List<Author>? authors = JsonSerializer.Deserialize<List<Author>>(json);
            Author? author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                throw new Exception("ID doesn't match an author");

            return author;

        }
    }
}
