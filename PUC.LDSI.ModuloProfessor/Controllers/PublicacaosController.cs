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
    public class PublicacaosController : Controller
    {
        private readonly AppDbContext _context;

        public PublicacaosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Publicacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Publicacoes.ToListAsync());
        }

        // GET: Publicacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacao = await _context.Publicacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publicacao == null)
            {
                return NotFound();
            }

            return View(publicacao);
        }

        // GET: Publicacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publicacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataPublicacao,DataInicio,DataFim,ValorProva,Id")] Publicacao publicacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publicacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publicacao);
        }

        // GET: Publicacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacao = await _context.Publicacoes.FindAsync(id);
            if (publicacao == null)
            {
                return NotFound();
            }
            return View(publicacao);
        }

        // POST: Publicacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DataPublicacao,DataInicio,DataFim,ValorProva,Id")] Publicacao publicacao)
        {
            if (id != publicacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publicacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublicacaoExists(publicacao.Id))
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
            return View(publicacao);
        }

        // GET: Publicacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacao = await _context.Publicacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publicacao == null)
            {
                return NotFound();
            }

            return View(publicacao);
        }

        // POST: Publicacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publicacao = await _context.Publicacoes.FindAsync(id);
            _context.Publicacoes.Remove(publicacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublicacaoExists(int id)
        {
            return _context.Publicacoes.Any(e => e.Id == id);
        }
    }
}
