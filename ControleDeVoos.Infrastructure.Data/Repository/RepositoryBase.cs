using ControleDeVoos.Domain.Core.Interfaces.Repository;
using ControleDeVoos.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVoos.Infrastructure.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                TEntity obj = _sqlContext.Set<TEntity>().Find(id);
                _sqlContext.Entry(obj).State = EntityState.Deleted;
                await _sqlContext.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<TEntity> Save(TEntity entity)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(entity);
                await _sqlContext.SaveChangesAsync();
                return entity;
            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                _sqlContext.Entry(entity).State = EntityState.Modified;
                await _sqlContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
