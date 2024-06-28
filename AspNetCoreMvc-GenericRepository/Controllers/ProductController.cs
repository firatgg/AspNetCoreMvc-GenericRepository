using AspNetCoreMvc_GenericRepository.Interface;
using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_GenericRepository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGenericRepository<Product> _productRepo;

        public ProductController(IGenericRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {

            var urun = _productRepo.GetById(2);
            return View(urun);
        }
    }
}
