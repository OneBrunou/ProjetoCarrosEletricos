using Microsoft.AspNetCore.Mvc;

namespace ProjetoCarros.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarrosHibridos()
        {
            return View();
        }
        public IActionResult CarrosEletricos()
        {
            return View();
        }
        public IActionResult TodosOsModelos()
        {
            return View();
        }
        public IActionResult Novos()
        {
            return View();
        }
        public IActionResult SemiNovos()
        {
            return View();
        }
    }
}
