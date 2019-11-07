using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Services.Interfaces;

namespace PUC.LDSI.Domain.Services
{
    public class ProvaService : IProvaService
    {
        private readonly IProvaRepository _provaRepository;

        public ProvaService(IProvaRepository provaRepository)
        {
            _provaRepository = provaRepository;
        }

        public async Task<int> AdicionarProvaAsync(Avaliacao avaliacao, Aluno aluno, DateTime dataProva, decimal notaObtida)
        {
            var prova = new Prova() { Avaliacao = avaliacao, Aluno = aluno, DataProva = dataProva, NotaEmitida = notaObtida };
            _provaRepository.Adicionar(prova);

            await _provaRepository.SaveChangesAsync();
            return prova.AvaliacaoId;
        }
        public async Task<int> AlterarProvaAsync(int id, Avaliacao avaliacao, Aluno aluno, DateTime dataProva, decimal notaObtida)
        {
            var prova = await _provaRepository.ObterAsync(id);
            prova.Avaliacao = avaliacao;

            _provaRepository.Modificar(prova);
            return await _provaRepository.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int id)
        {
            var prova = await _provaRepository.ObterAsync(id);
            _provaRepository.Remover(id);
            await _provaRepository.SaveChangesAsync();

        }
    }
}

       
