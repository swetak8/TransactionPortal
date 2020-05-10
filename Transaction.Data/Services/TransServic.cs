using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Transaction.Data.Context;
using Transaction.Domain.Models;
using Transaction.Domain.Repository;

namespace Transaction.Data.Services
{
    public class TransServic : ITransaction
    {
        private readonly TransactionContext transactionContext;

        public TransServic(TransactionContext transactionContext)
        {
            this.transactionContext = transactionContext;
        }

        public IEnumerable<PortalTrx> GetUpdates()
        {
            return transactionContext.PortalTrx;
        }

        public string PostStatus(string value)
        {
            var serialize = JsonConvert.SerializeObject(value);
            PortalTrx pt = new PortalTrx();
            pt.sValue = serialize;
            pt.modifiedDate = DateTime.Now;

            transactionContext.PortalTrx.Add(pt);
            transactionContext.SaveChanges();
            return $"Content Updated";
        }
    }
}
