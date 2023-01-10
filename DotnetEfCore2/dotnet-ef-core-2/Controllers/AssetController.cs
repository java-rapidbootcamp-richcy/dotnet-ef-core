using dotnet_ef_core_2.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_2.Controllers
{
    public class AssetController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssetController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<AssetEntity> assets = _context.AssetEntities.ToList();
            return View(assets);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            AssetEntity category = _context.AssetEntities.Find(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("AssetName, Specification, SerialNumber, PurchaseYear, IdPic")] AssetEntity request)
        {
            _context.AssetEntities.Add(request);
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.AssetEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.AssetEntities.Find(id);
            if(entity == null)
            {
                return Redirect("/Category/Delete");
            }
            _context.AssetEntities.Remove(entity);
            _context.SaveChanges();
            return Redirect("/Category/Delete");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,AssetName, Specification, SerialNumber, PurchaseYear, IdPic")] AssetEntity request)
        {
            _context.AssetEntities.Update(request);
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
