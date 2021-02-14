using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ControleDeVoos.Domain.Entities
{
    public class InformacaoVoo : BaseEntity
    {
        [Required]
        public string Matricula { get; set; }

        [Required]
        public string Aeronave { get; set; }

        [Required]
        public DateTime DataVoo { get; set; }

        [Required]
        public TimeSpan HoraVoo { get; set; }

        [Required]
        public string Origem { get; set; }

        [Required]
        public string Destino { get; set; }
    }

    public class InformacaoVooValidator: AbstractValidator<InformacaoVoo>
    {
        public InformacaoVooValidator()
        {
            RuleFor(x => x.Matricula).Length(0, 50).WithMessage("Matricula não pode ser maior que 50");
            RuleFor(x => x.Matricula).NotEmpty().WithMessage("Maricula é obrigatório");
        }
    }
}
