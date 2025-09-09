using ETicaretAPI.Application.Commands.Request.ProductRequest;
using MediatR;

namespace ETicaretAPI.Application.Commands.Handler.ProductHandler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var response = _unitOfWork.ProductWriteRepository.Update(request);
            await _unitOfWork.SaveAsync();
            return true;
        }
    }
}
