using Facturita.Core.Models;
using Facturita.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Facturita.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IRepository<Cliente> _clienteRepository;

        public ClientesController(IRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteRepository.GetAllAsync();
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _clienteRepository.GetByIdAsync(id.Value);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Identificacion,Direccion,Telefono,Email")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await _clienteRepository.AddAsync(cliente);
                await _clienteRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _clienteRepository.GetByIdAsync(id.Value);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Identificacion,Direccion,Telefono,Email")] Cliente cliente)
        {
            if (id != cliente.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _clienteRepository.Update(cliente);
                await _clienteRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _clienteRepository.GetByIdAsync(id.Value);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente != null)
            {
                _clienteRepository.Delete(cliente);
                await _clienteRepository.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
