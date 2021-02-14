using ControleDeVoos.Domain.Core.Interfaces.Repository;
using ControleDeVoos.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVoos.Services.Services
{
    public class ServiceBase<TEntity>: IServiceBase<TEntity> where TEntity  :class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repositoryBase.Delete(id);
        }

        public async Task<TEntity> Save(TEntity entity)
        {
            return await _repositoryBase.Save(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await _repositoryBase.Update(entity);
        }
    }
}
