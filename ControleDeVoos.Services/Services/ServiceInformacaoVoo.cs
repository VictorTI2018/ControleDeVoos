using AutoMapper;
using ControleDeVoos.Domain.Core.Interfaces.Repository;
using ControleDeVoos.Domain.Core.Interfaces.Services;
using ControleDeVoos.Domain.Dtos.InformacaoVoo;
using ControleDeVoos.Domain.Entities;
using ControleDeVoos.Domain.Response;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVoos.Services.Services
{
    public class ServiceInformacaoVoo : ServiceBase<InformacaoVoo>, IServiceInformacaoVoo
    {
        private readonly IRepositoryInformacaoVoo _repositoryInformacaoVoo;
        private readonly IMapper _mapper;

        public ServiceInformacaoVoo(IRepositoryInformacaoVoo repositoryInformacaoVoo,
            IMapper mapper) : base(repositoryInformacaoVoo)
        {
            _repositoryInformacaoVoo = repositoryInformacaoVoo;
        }

        public async Task<ResponseDto> Cadastrar(InformacaoVooDadosDto dados)
        {
            InformacaoVoo infoVoo = _mapper.Map<InformacaoVooDadosDto, InformacaoVoo>(dados);

            ValidationResult result = new InformacaoVooValidator().Validate(infoVoo);
            if (!result.IsValid)
            {
                return new ResponseDto(result);
            }
            infoVoo.Id = Guid.NewGuid();

            await _repositoryInformacaoVoo.Save(infoVoo);

            return new ResponseDto(
                _mapper.Map<InformacaoVoo, InformacaoVooDadosDto>(infoVoo)
                );
        }
    }
}
