using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.Context
{
    public class SqlContext: DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
    }
}
