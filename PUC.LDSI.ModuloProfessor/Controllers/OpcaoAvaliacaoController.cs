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
    public class OpcaoAvaliacaoController : BaseController
    {
        private readonly IOpcaoAvaliacaoService _opcaoAvalicaoService;
        private readonly IOpcaoAvaliacaoRepository _opcaoAvalicaoRepository;

        public OpcaoAvaliacaoController(IOpcaoAvaliacaoService opcaoAvaliacaoService, IOpcaoAvaliacaoRepository opcaoAvaliacaoRepository, UserManager<Usuario> _user) : base(_user)
        {
            _opcaoAvalicaoService = opcaoAvaliacaoService;
            _opcaoAvalicaoRepository = opcaoAvaliacaoRepository;
        }

        // GET: OpcaoAvaliacao
        public async Task<IActionResult> Index()
        {
            return View(await _opcaoAvalicaoRepository.ListarTodosAsync());
        }
        /*
        // GET: OpcaoAvaliacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _opcaoAvalicao.OpcoesAvaliacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }
        */
        // GET: OpcaoAvaliacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OpcaoAvaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Verdadeira,Id")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                await _opcaoAvalicaoService.AdicionarOpcaoAvaliacaoAsync(opcaoAvaliacao.Descricao, opcaoAvaliacao.Verdadeira,opcaoAvaliacao.Questao);
                return RedirectToAction(nameof(Index));
            }
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _opcaoAvalicaoRepository.ObterAsync(id.Value);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }
            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacao/Edit/5
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
                await _opcaoAvalicaoService.AlterarOpcaoAvaliacaoAsync(opcaoAvaliacao.Id, opcaoAvaliacao.Descricao, opcaoAvaliacao.Verdadeira,opcaoAvaliacao.Questao);
                return RedirectToAction(nameof(Index));
            }

            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _opcaoAvalicaoRepository.ObterAsync(id.Value);
    

        if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _opcaoAvalicaoService.ExcluirAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
