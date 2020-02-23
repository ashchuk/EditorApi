using Microsoft.AspNetCore.Mvc;

namespace EditorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EditorController : Controller
    {
        [HttpGet]
        public string GetEditor()
        {
            return "editor";
        }
    }
}