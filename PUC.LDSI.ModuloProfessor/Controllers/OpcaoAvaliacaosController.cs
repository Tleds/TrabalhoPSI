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
    public class OpcaoAvaliacaosController : Controller
    {
        private readonly AppDbContext _context;

        public OpcaoAvaliacaosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OpcaoAvaliacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.OpcoesAvaliacao.ToListAsync());
        }

        // GET: OpcaoAvaliacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcoesAvaliacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OpcaoAvaliacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Verdadeira,Id")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opcaoAvaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcoesAvaliacao.FindAsync(id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }
            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao,Verdadeira,Id")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (id != opcaoAvaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opcaoAvaliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcaoAvaliacaoExists(opcaoAvaliacao.Id))
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
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcoesAvaliacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opcaoAvaliacao = await _context.OpcoesAvaliacao.FindAsync(id);
            _context.OpcoesAvaliacao.Remove(opcaoAvaliacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpcaoAvaliacaoExists(int id)
        {
            return _context.OpcoesAvaliacao.Any(e => e.Id == id);
        }
    }
}
