using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class PageResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PageResponse(T value, int pageSize, int pageNumber) : base(value)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }

}
