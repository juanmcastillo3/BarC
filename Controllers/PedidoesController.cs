using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarC.Context;
using BarC.Models;
using Microsoft.AspNetCore.Http;

namespace BarC.Controllers
{
    public class PedidoesController : Controller
    {
        private readonly BarDatabaseContext _context;

        public PedidoesController(BarDatabaseContext context)
        {
            _context = context;
        }

        // GET: Pedidoes
        public async Task<IActionResult> Index()
        {
            ViewBag.role = HttpContext.Session.GetInt32("userRole");
            var role = HttpContext.Session.GetInt32("userRole");
            var id = HttpContext.Session.GetInt32("userID");
            if (role != 1)
            {
                return View(_context.Pedido.Where(a => a.IdUsuario == id));
            }
            ViewBag.role = role;
            return View(await _context.Pedido.OrderByDescending(a => a.IdUsuario).ToListAsync());
        }

        // GET: Pedidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdNumero == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidoes/Create
        public IActionResult Create()
        {
            ViewBag.role = HttpContext.Session.GetInt32("userRole");
            return View();
        }

        // POST: Pedidoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNumero")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                pedido.IdUsuario= (int)HttpContext.Session.GetInt32("userID");
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                int pedidoMax = _context.Pedido.Max(u => u.IdNumero);
                HttpContext.Session.SetInt32("pedido", pedido.IdNumero);

                return RedirectToAction("Create", "Productoes");
            }
            return View(pedido);
        }
   
        // GET: Pedidoes/Edit/5
          public async Task<IActionResult> Edit(int? id)
            {

                if (id == null)
                {
                    return NotFound();
                 }

            var pedido = await _context.Pedido.FindAsync(id);
                    if (pedido == null)
                    {
                        return NotFound();
        }
            HttpContext.Session.SetInt32("pedido", pedido.IdNumero);
        
            return RedirectToAction("Consultar", "Productoes");

}
// POST: Pedidoes/Edit/5
//To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//more details see http://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
     [ValidateAntiForgeryToken]
     public async Task<IActionResult> Edit(int id, [Bind("IdNumero")] Pedido pedido)
         {
             if (id != pedido.IdNumero)
             {
                 return NotFound();
    }

             if (ModelState.IsValid)
             {
                 try
                 {
    _context.Update(pedido);
    await _context.SaveChangesAsync();
    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PedidoExists(pedido.IdNumero))
                        {
                            return NotFound();
    }
                       else
                       {
                           throw;
    }
    }
                    return RedirectToAction(nameof(Index));
}
        return View(pedido);
    }

// GET: Pedidoes/Delete/5
public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdNumero == id);
            if (pedido == null)
            {
                return NotFound();
            }
            var monto = _context.Producto.ToList();
            var montoAUX = monto.Where(a => a.Pedidofk == id);
            var montoFIN = montoAUX.Sum(b => b.Precio);
            ViewBag.montoFIN = montoFIN;
            ViewBag.role = HttpContext.Session.GetInt32("userRole");

            return View(pedido);
        }

        // POST: Pedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            DateTime Today = DateTime.Now;

            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            var monto = _context.Producto.ToList();
            var montoAUX = monto.Where(a => a.Pedidofk == id);
            var montoFIN = montoAUX.Sum(b => b.Precio);
            var nombreUser = HttpContext.Session.GetString("username");
            Historial hist = new Historial
            {
                IdPedido = id,
                Total = montoFIN,
                IdUsuario = pedido.IdUsuario,
                Fecha = Today,
                Usuario = nombreUser
            };
            _context.Historial.Add(hist);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.IdNumero == id);
        }

    }
}
