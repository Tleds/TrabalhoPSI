using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    public class PublicacaoService : IPublicacaoService
    {
        private readonly IPublicacaoRepository _publicacaoRepository;
        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }
        public async Task<int> AdicionarPublicacaoAsync(Avaliacao avaliacao, DateTime dataPublicacao, Turma turmas, DateTime dataInicio, DateTime dataFim, int valorProva)
        {
            var publicacao = new Publicacao() { Avaliacao = avaliacao,DataPublicacao = dataPublicacao,Turma = turmas,DataInicio = dataInicio,DataFim = dataFim,ValorProva = valorProva };
            _publicacaoRepository.Adicionar(publicacao);
            await _publicacaoRepository.SaveChangesAsync();
            return publicacao.Id;
        }
        public async Task<int> AlterarPublicacaoAsync(int id,Avaliacao avaliacao, DateTime dataPublicacao, Turma turmas, DateTime dataInicio, DateTime dataFim, int valorProva)
        {
            var publicacao = await _publicacaoRepository.ObterAsync(id);

            
            _publicacaoRepository.Modificar(publicacao);
            return await _publicacaoRepository.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int id)
        {
            
            _publicacaoRepository.Remover(id);
            await _publicacaoRepository.SaveChangesAsync();
        }
    }
}
