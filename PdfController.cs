using Microsoft.AspNetCore.Mvc;

namespace PdfTronTestService
{
    [ApiController]
    [Route("[controller]")]
    public class PdfController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "yes it works";
        }
        
    }
}