using AutoMapper;
using MediatR;
using ProductApp.Application.Dtos;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductGetByIdViewModel>>
    {
        IProductRepository productRepository;
        IMapper mapper;
        public GetProductByIdHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<ServiceResponse<GetProductGetByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync();
            var dto = mapper.Map<GetProductGetByIdViewModel>(product);
            return new ServiceResponse<GetProductGetByIdViewModel>(dto);
        }
    }
}
