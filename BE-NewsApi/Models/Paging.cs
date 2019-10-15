using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_NewsApi.Models
{
    public class Paging
    {

        public int PageSize { get; set; } = 10;

        public int PageNumber { get; set; } = 1;



    }
}
