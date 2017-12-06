using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParsePro.Models
{
    public class ParseResponse
    {
        public string message { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
    }
}