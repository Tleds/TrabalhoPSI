using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using PUC.LDSI.Domain.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;


namespace PUC.LDSI.Domain.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<int> IncluirNovoAlunoAsync(string nome, string matricula)
        {
            var aluno = new Aluno() { Nome = nome, Matricula = matricula };
            return await _alunoRepository.IncluirNovoAlunoAsync(aluno);
        }
       
    }
}
