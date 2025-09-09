using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Queries.Handler.ProductHandler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var response = await unitOfWork.ProductReadRepository.GetAllAsync();
            return response;
        }
    }
    public record GetAllProductsQuery : IRequest<List<Product>> { }
}
