using ControleDeVoos.Domain.Dtos.InformacaoVoo;
using ControleDeVoos.Domain.Entities;
using ControleDeVoos.Domain.Response;
using System.Threading.Tasks;

namespace ControleDeVoos.Domain.Core.Interfaces.Services
{
    public interface IServiceInformacaoVoo: IServiceBase<InformacaoVoo>
    {

        Task<ResponseDto> Cadastrar(InformacaoVooDadosDto dados);
    }
}
