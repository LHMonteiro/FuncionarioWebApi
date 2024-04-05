using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funcionario.Enums;

namespace Funcionario.Models
{
    public class FuncionarioModel
    {
        public string Name { get; private set; }
        public Guid Id { get; init; }
        public string Sobrinome { get; private set; }
        public DeparatamentoEnum Departamento { get; private set; }
        public HorariosEnum Horario { get; private set; }
        public bool Ativo { get; private set; }
        public ModalidadeEnum Modalidade { get; private set; }
        public DateTime DataAtiva { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataAlter { get; set; } = DateTime.Now.ToLocalTime();
    }
}