using cs_MVC_sprint.Models;



namespace cs_MVC_sprint.Services
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
    }
    public class AuthorService : IAuthorService
    {

        public AuthorModel _authorModel;
        public AuthorService (AuthorModel authorModel)
        {
            _authorModel = authorModel;
        }
        public List<Author> GetAllAuthors()
        {
            return _authorModel.GetAllAuthors();
        }
        public Author GetAuthorById(int id)
        {
            return _authorModel.GetAuthorById(id);
        }
    }
}
