using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;
using PUC.LDSI.ModuloProfessor.Controllers;

public class AvaliacaoController : BaseController
{
    private readonly IAvaliacaoService _avaliacaoService;
    private readonly IAvaliacaoRepository _avaliacaoRepository;
    private readonly IProfessorRepository _professorRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AvaliacaoController(IAvaliacaoService avaliacaoService,
    IAvaliacaoRepository avaliacaoRepository,
    UserManager<Usuario> _user,
    IHttpContextAccessor httpContextAccessor,
    IProfessorRepository professorRepository) : base(_user)
    {
        _avaliacaoService = avaliacaoService;
        _avaliacaoRepository = avaliacaoRepository;
        _httpContextAccessor = httpContextAccessor;
        _professorRepository = professorRepository;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _avaliacaoRepository.ListarTodosAsync());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Descricao,Materia,Disciplina,Id")] Avaliacao avaliacao)
    {
        var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        avaliacao.Professor = _professorRepository.ObterPorLogin(user.Result.UserName);
        avaliacao.ProfessorId = avaliacao.Professor.Id;
        if (ModelState.IsValid)
        {
            await _avaliacaoService.AdicionarAvaliacaoAsync(avaliacao);
            return RedirectToAction(nameof(Index));
        }
        return View(avaliacao);
    }
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var avaliacao = await _avaliacaoRepository.ObterAsync(id.Value);
        if (avaliacao == null)
        {
            return NotFound();
        }
        return View(avaliacao);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Descricao,Materia,Disciplina,Id")] Avaliacao avaliacao)
    {
        if (id != avaliacao.ProfessorId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            await _avaliacaoService.AlterarAvaliacaoAsync(avaliacao);
            return RedirectToAction(nameof(Index));
        }
        return View(avaliacao);
    }
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var avaliacao = await _avaliacaoRepository.ObterAsync(id.Value);
        if (avaliacao == null)
        {
            return NotFound();
        }
        return View(avaliacao);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _avaliacaoService.ExcluirAsync(id);

        return RedirectToAction(nameof(Index));
    }
}
