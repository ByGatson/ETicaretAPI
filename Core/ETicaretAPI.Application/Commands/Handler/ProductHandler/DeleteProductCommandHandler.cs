using ETicaretAPI.Application.Commands.Request.ProductRequest;
using MediatR;

namespace ETicaretAPI.Application.Commands.Handler.ProductHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _unitOfWork.ProductWriteRepository.RemoveAsync(request.Id);
            await _unitOfWork.SaveAsync();
            return response;
        }
    }
}
