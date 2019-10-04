using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Services.Interfaces;
namespace PUC.LDSI.Domain.Services
{

    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }
        public async Task<int> IncluirNovoProfessorAsync(string login, string nome)
        {
            var professor = new Professor() { Nome = nome, Login = login };
            return await _professorRepository.IncluirNovoProfessorAsync(professor);
        }
    }

}
