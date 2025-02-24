using System.Diagnostics;
using Chat_Bot_DeepSeek.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Chat_Bot_DeepSeek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DeepSeekService _deepSeekService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _deepSeekService = new DeepSeekService(new HttpClient());
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage([FromBody] ChatRequest request)
        {
            var response = _deepSeekService.SendMessageAsync(new ChatRequest { Message = request.Message});
            return Json(new { respuesta = response.Result.Choices[0].Message.Content });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
