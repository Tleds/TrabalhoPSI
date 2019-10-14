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
    public class ProvasController : Controller
    {
        private readonly AppDbContext _context;

        public ProvasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Provas
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Provas.Include(p => p.Aluno).Include(p => p.Avaliacao);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Provas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prova = await _context.Provas
                .Include(p => p.Aluno)
                .Include(p => p.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prova == null)
            {
                return NotFound();
            }

            return View(prova);
        }

        // GET: Provas/Create
        public IActionResult Create()
        {
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id");
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id");
            return View();
        }

        // POST: Provas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,AlunoId,NotaEmitida,DataProva,Id")] Prova prova)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prova);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(prova);
        }

        // GET: Provas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prova = await _context.Provas.FindAsync(id);
            if (prova == null)
            {
                return NotFound();
            }
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(prova);
        }

        // POST: Provas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,AlunoId,NotaEmitida,DataProva,Id")] Prova prova)
        {
            if (id != prova.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prova);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProvaExists(prova.Id))
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
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(prova);
        }

        // GET: Provas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prova = await _context.Provas
                .Include(p => p.Aluno)
                .Include(p => p.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prova == null)
            {
                return NotFound();
            }

            return View(prova);
        }

        // POST: Provas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prova = await _context.Provas.FindAsync(id);
            _context.Provas.Remove(prova);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProvaExists(int id)
        {
            return _context.Provas.Any(e => e.Id == id);
        }
    }
}
