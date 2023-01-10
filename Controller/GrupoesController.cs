//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using ControlSmart.Data;
//using Dados_Smart.Controller;

//namespace ControlSmart.Controller
//{
//    public class GrupoesController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public GrupoesController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Grupoes
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Grupo.ToListAsync());
//        }

//        // GET: Grupoes/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var grupo = await _context.Grupo
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (grupo == null)
//            {
//                return NotFound();
//            }

//            return View(grupo);
//        }

//        // GET: Grupoes/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Grupoes/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("ID,Nome_Inicio,Data_Inicio")] Grupo grupo)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(grupo);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(grupo);
//        }

//        // GET: Grupoes/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var grupo = await _context.Grupo.FindAsync(id);
//            if (grupo == null)
//            {
//                return NotFound();
//            }
//            return View(grupo);
//        }

//        // POST: Grupoes/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome_Inicio,Data_Inicio")] Grupo grupo)
//        {
//            if (id != grupo.ID)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(grupo);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!GrupoExists(grupo.ID))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(grupo);
//        }

//        // GET: Grupoes/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var grupo = await _context.Grupo
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (grupo == null)
//            {
//                return NotFound();
//            }

//            return View(grupo);
//        }

//        // POST: Grupoes/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var grupo = await _context.Grupo.FindAsync(id);
//            _context.Grupo.Remove(grupo);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool GrupoExists(int id)
//        {
//            return _context.Grupo.Any(e => e.ID == id);
//        }
//    }
//}
