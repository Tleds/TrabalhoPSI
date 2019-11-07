using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.ModuloProfessor.Controllers
{
    public class QuestaoProvasController : Controller
    {
        private readonly AppDbContext _context;

        public QuestaoProvasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: QuestaoProvas
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestoesProva.ToListAsync());
        }

        // GET: QuestaoProvas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questaoProva = await _context.QuestoesProva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questaoProva == null)
            {
                return NotFound();
            }

            return View(questaoProva);
        }

        // GET: QuestaoProvas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestaoProvas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nota,Id")] QuestaoProva questaoProva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questaoProva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questaoProva);
        }

        // GET: QuestaoProvas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questaoProva = await _context.QuestoesProva.FindAsync(id);
            if (questaoProva == null)
            {
                return NotFound();
            }
            return View(questaoProva);
        }

        // POST: QuestaoProvas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nota,Id")] QuestaoProva questaoProva)
        {
            if (id != questaoProva.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questaoProva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestaoProvaExists(questaoProva.Id))
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
            return View(questaoProva);
        }

        // GET: QuestaoProvas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questaoProva = await _context.QuestoesProva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questaoProva == null)
            {
                return NotFound();
            }

            return View(questaoProva);
        }

        // POST: QuestaoProvas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questaoProva = await _context.QuestoesProva.FindAsync(id);
            _context.QuestoesProva.Remove(questaoProva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestaoProvaExists(int id)
        {
            return _context.QuestoesProva.Any(e => e.Id == id);
        }
    }
}
