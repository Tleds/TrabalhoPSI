using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;

namespace PUC.LDSI.ModuloProfessor.Controllers
{
    public class ProvaController : BaseController
    {
        //private readonly AppDbContext _context;
        private readonly IProvaService _ProvaService;
        private readonly IProvaRepository _ProvaRepository;

        public ProvaController(IProvaService provaService, IProvaRepository provaRepository, UserManager<Usuario> _user) : base (_user)
        {
            _ProvaService = provaService;
            _ProvaRepository = provaRepository;
        }

        // GET: Prova
        public async Task<IActionResult> Index()
        {
            // var appDbContext = _context.Provas.Include(p => p.Aluno).Include(p => p.Avaliacao);
            return View(await _ProvaRepository.ListarTodosAsync());
        }
        /*
        // GET: Prova/Details/5
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
            
            return View();
        }
        */
        // GET: Prova/Create
        public IActionResult Create()
        {
            /*
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id");
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id");
            */
            return View();
        }

        // POST: Prova/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,AlunoId,NotaEmitida,DataProva,Id")] Prova avaliacao)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(prova);
                // await _context.SaveChangesAsync();
                await _ProvaService.AdicionarProvaAsync(avaliacao.Avaliacao, avaliacao.Aluno,avaliacao.DataProva,avaliacao.NotaEmitida);
                return RedirectToAction(nameof(Index));
            }
           // ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
           // ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(avaliacao);
        }

        // GET: Prova/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prova = await _ProvaRepository.ObterAsync(id.Value);
            if (prova == null)
            {
                return NotFound();
            }
           // ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
           // ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(prova);
        }

        // POST: Prova/Edit/5
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
                /*
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
                */
                await _ProvaService.AlterarProvaAsync(prova.Id, prova.Avaliacao,prova.Aluno,prova.DataProva,prova.NotaEmitida);
                return RedirectToAction(nameof(Index));
            }
          //  ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "Id", prova.AlunoId);
          // ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", prova.AvaliacaoId);
            return View(prova);
        }

        // GET: Prova/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prova = await _ProvaRepository.ObterAsync(id.Value);
               /* .Include(p => p.Aluno)
                .Include(p => p.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
                */
            if (prova == null)
            {
                return NotFound();
            }

            return View(prova);
        }
        /*
                // POST: Prova/Delete/5
                [HttpPost, ActionName("Delete")]
                [ValidateAntiForgeryToken]
                public async Task<IActionResult> DeleteConfirmed(int id)
                {
                    await _ProvaRepository.ExcluirAsync(id);

                    return RedirectToAction(nameof(Index));
                }
                /*
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
                */
    }
}
