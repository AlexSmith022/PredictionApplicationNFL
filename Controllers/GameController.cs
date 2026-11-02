using Microsoft.AspNetCore.Mvc;
using NFLPredictions.Services;
using System.Threading.Tasks;

namespace NFLPredictions.Controllers
{
    public class GamesController : Controller
    {
        private readonly EspnNflService _espnNflService;

        public GamesController(EspnNflService espnNflService)
        {
            _espnNflService = espnNflService;
        }

        public async Task<IActionResult> Index()
        {
            string json = await _espnNflService.GetScoreboardAsync();

            ViewBag.Json = json;

            return View();
        }
    }
}