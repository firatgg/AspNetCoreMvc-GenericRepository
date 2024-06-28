using AspNetCoreMvc_GenericRepository.Interface;
using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_GenericRepository.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IGenericRepository<Category> _categoryRepo;

        public CategoryController(IGenericRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            //var kategor = _categoryRepo.GetById(2);
            var kategori = _categoryRepo.Get(c => c.Id == 2);
            //ViewBag.kategori = kategori;
            return View(kategori);
        }
    }
}
