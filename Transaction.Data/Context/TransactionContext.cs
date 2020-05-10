using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Transaction.Domain.Models;

namespace Transaction.Data.Context
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
        {

        }
        public DbSet<PortalTrx> PortalTrx { get; set; }
    }
}
