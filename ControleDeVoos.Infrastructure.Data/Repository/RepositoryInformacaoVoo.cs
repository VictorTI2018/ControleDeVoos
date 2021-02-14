using ControleDeVoos.Domain.Core.Interfaces.Repository;
using ControleDeVoos.Domain.Entities;
using ControleDeVoos.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.Data.Repository
{
    public class RepositoryInformacaoVoo: RepositoryBase<InformacaoVoo>, IRepositoryInformacaoVoo
    {
        private readonly SqlContext _sqlContext;

        public RepositoryInformacaoVoo(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
