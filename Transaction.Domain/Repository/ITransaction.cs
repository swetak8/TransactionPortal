using System;
using System.Collections.Generic;
using System.Text;
using Transaction.Domain.Models;

namespace Transaction.Domain.Repository

{
    public interface ITransaction
    {
        string PostStatus(string value);
        IEnumerable<PortalTrx> GetUpdates();
    }
}
