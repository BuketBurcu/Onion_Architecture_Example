using MediatR;
using ProductApp.Application.Dtos;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductGetByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
