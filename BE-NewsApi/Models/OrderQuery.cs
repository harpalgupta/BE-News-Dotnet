using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_NewsApi.Models
{
    public class OrderQuery
    {
        public string OrderBy { get; set; }

        public string Direction { get; set; } = "descending";

    }
}
