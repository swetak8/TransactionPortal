using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Transaction.Data.Services;
using Transaction.Domain.Models;
using Transaction.Domain.Repository;

namespace IBPortalTransaction.Controllers
{
    [Route("api/Transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransaction transaction;

        public TransactionController(ITransaction transaction)
        {
            this.transaction = transaction;
        }
        // GET: api/Transaction
        [HttpGet]
        public IEnumerable<PortalTrx> Get()
        {
            var q = transaction.GetUpdates();
            return q;
        }

        [Route("PostStatusUpdates/{value}")]
        [HttpPost]        
        public string PostStatusUpdates(string value, [FromBody]string content)
        {

            string s = transaction.PostStatus(value);
            return s;

        }
    }
}
