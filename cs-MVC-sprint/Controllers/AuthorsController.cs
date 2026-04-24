using cs_MVC_sprint.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using cs_MVC_sprint.Services;

namespace cs_MVC_sprint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        public IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            var authors = _authorService.GetAllAuthors();
            return Ok(authors);
        }
    }
}
