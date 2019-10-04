using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class Avaliacao : Entity
    {

        
        [StringLength(100)]
        public string Disciplina { get; set; }
        [StringLength(100)]
        public string Materia { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        [ForeignKey("Aluno")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<Publicacao> Publicacoes { get; set; }
        public List<Questao> Questoes { get; set; }
        public List<Prova> Provas { get; set; }
    }
}
