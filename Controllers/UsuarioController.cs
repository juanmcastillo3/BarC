using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarC.Context;
using BarC.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Http;


namespace BarC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly BarDatabaseContext _context;
        private Usuario usuarioContext;

        public UsuarioController(BarDatabaseContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var role = HttpContext.Session.GetInt32("userRole");
            var id = HttpContext.Session.GetInt32("userID");
            if (role != 1){
                return RedirectToAction("IndexUser", "Usuario");
            }
            return View(await _context.Usuario.ToListAsync());
        }
        public async Task<IActionResult> IndexUser()
        {
            var role = HttpContext.Session.GetInt32("userRole");
            var id = HttpContext.Session.GetInt32("userID");
            
            return View(_context.Usuario.Where(a => a.Id == id));
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }
        //  REFERENCIA ABM
        public IActionResult ABM()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        public async Task<IActionResult> Login(String mail, String password)
        {
            if (ModelState.IsValid)
            {
                var usuarioFromDB = await _context.Usuario.FirstOrDefaultAsync(usu => usu.Email == mail && usu.Password == password);
                if (usuarioFromDB == null)
                {
                    ViewBag.Error = "Datos incorrectos.";
                    return View();
                }
                //HttpContext.Current.Session["nombreCompleto "] = "Pedro Pérez";
                usuarioContext = usuarioFromDB;
                HttpContext.Session.SetString("user", mail);
                HttpContext.Session.SetInt32("userID", usuarioFromDB.Id);
                HttpContext.Session.SetString("username", usuarioFromDB.Nombre);
                HttpContext.Session.SetInt32("userRole", usuarioFromDB.Role);
                var userRole = usuarioFromDB.Role;
                ViewBag.role = userRole;

                if (userRole == 1)
                {
                    return RedirectToAction("Homeadmin", "Home");
                }
                return RedirectToAction("Homebar", "Home");
            }
            return View(null);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Password,Nombre,Apellido,DNI,Edad,Email,FechaNacimiento,Role")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Password,Nombre,Apellido,DNI,Edad,Email,FechaNacimiento,Role")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("username", String.Empty);
            HttpContext.Session.SetString("user", String.Empty);  
            return RedirectToAction("Login", "Usuario");
        }
    }
}

