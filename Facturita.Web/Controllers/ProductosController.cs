using Facturita.Core.Models;
using Facturita.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Facturita.Web.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IRepository<Producto> _productoRepository;

        public ProductosController(IRepository<Producto> productoRepository)
        {
            _productoRepository = productoRepository;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var productos = await _productoRepository.GetAllAsync();
            return View(productos);
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var producto = await _productoRepository.GetByIdAsync(id.Value);
            if (producto == null) return NotFound();

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nombre,Descripcion,PrecioCompra,PrecioVenta,Stock")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                await _productoRepository.AddAsync(producto);
                await _productoRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var producto = await _productoRepository.GetByIdAsync(id.Value);
            if (producto == null) return NotFound();

            return View(producto);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nombre,Descripcion,PrecioCompra,PrecioVenta,Stock")] Producto producto)
        {
            if (id != producto.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _productoRepository.Update(producto);
                await _productoRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var producto = await _productoRepository.GetByIdAsync(id.Value);
            if (producto == null) return NotFound();

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);
            if (producto != null)
            {
                _productoRepository.Delete(producto);
                await _productoRepository.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}