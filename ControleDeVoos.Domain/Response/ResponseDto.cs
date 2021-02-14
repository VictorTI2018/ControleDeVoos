using ControleDeVoos.Domain.Dtos.InformacaoVoo;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Text;

namespace ControleDeVoos.Domain.Response
{
    public class ResponseDto : BaseResponse<InformacaoVooDadosDto>
    {
        public ResponseDto(InformacaoVooDadosDto dados) : base(dados) { }
        public ResponseDto(List<string> message) : base(message) { }
        public ResponseDto(ValidationResult validationResult) : base(validationResult) { }
    }
}
