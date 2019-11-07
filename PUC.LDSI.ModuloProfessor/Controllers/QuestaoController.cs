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
    public class QuestaoController : BaseController
    {
        private readonly IQuestaoService _questaoService;
        private readonly IQuestaoRepository _questaoRepository;

        public QuestaoController(IQuestaoService questaoService, IQuestaoRepository questaoRepository, UserManager<Usuario> _user) : base(_user)
        {
            _questaoService = questaoService;
            _questaoRepository = questaoRepository;
        }

        // GET: Questao
        public async Task<IActionResult> Index()
        {
            return View(await _questaoRepository.ListarTodosAsync());
        }
        /*
         // GET: Questao/Details/5
         public async Task<IActionResult> Details(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var questao = await _context.Questoes
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (questao == null)
             {
                 return NotFound();
             }

             return View(questao);
         }
         */
        // GET: Questao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Questao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo,Enunciado,Id")] Questao questao)
        {
            if (ModelState.IsValid)
            {
                await _questaoService.AdicionarQuestaoAsync(questao.Enunciado, questao.Tipo, questao.Avaliacao);
                return RedirectToAction(nameof(Index));
            }
            return View(questao);
        }

        // GET: Questao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _questaoRepository.ObterAsync(id.Value);
            if (questao == null)
            {
                return NotFound();
            }
            return View(questao);
        }

        // POST: Questao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Tipo,Enunciado,Id")] Questao questao)
        {
            if (id != questao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _questaoService.AlterarQuestaoAsync(questao.Id, questao.Enunciado, questao.Tipo, questao.Avaliacao);
                return RedirectToAction(nameof(Index));
            }
            return View(questao);
        }

        // GET: Questao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _questaoRepository.ObterAsync(id.Value);
            if (questao == null)
            {
                return NotFound();
            }
            return View(questao);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _questaoService.ExcluirAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
