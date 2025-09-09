using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Queries.Handler.ProductHandler
{
    public class GetByIdProductsQueryHandler : IRequestHandler<GetByIdProductsQuery, Product>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetByIdProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Product?> Handle(GetByIdProductsQuery request, CancellationToken cancellationToken)
            => await unitOfWork.ProductReadRepository.GetByIdAsync(request.Id);

    }
    public record GetByIdProductsQuery(string Id) : IRequest<Product> { }
}
