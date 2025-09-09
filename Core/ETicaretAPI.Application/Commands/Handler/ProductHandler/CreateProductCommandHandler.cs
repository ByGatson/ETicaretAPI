using ETicaretAPI.Application.Commands.Request.ProductRequest;
using MediatR;

namespace ETicaretAPI.Application.Commands.Handler.ProductHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _unitOfWork.ProductWriteRepository.AddAsync(request);
            await _unitOfWork.SaveAsync();
            return response;
        }
    }
}
