using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Transaction.Domain.Models
{
    public class PortalTrx
    {
        [Key]
        public int Id { get; set; }
        public string sValue { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
