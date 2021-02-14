using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVoos.Domain.Core.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity>
    {
        Task<TEntity> Save(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<bool> Delete(int id);

    }
}
