using Microsoft.AspNetCore.Mvc;
using MVCExercise.Services;
using MVCExercise.ViewModels;

namespace MVCExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ColorService _colorService;

        public HomeController(ColorService colorService)
        {
            _colorService = colorService;
        }

        public IActionResult Index()
        {
            var model = new DisplayColorsListViewModel();

            model.ColorList = _colorService.PopulateColorList();         

            return View(model);
        }
    }
}
