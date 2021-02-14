using ControleDeVoos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.Data.Context
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<InformacaoVoo> InformacaoVoo { get; set; }
    }
}
