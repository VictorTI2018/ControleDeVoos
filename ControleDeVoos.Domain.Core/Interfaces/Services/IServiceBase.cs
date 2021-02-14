using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVoos.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity>
    {
        Task<TEntity> Save(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<bool> Delete(int id);
    }
}
