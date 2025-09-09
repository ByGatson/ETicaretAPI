using MediatR;

namespace ETicaretAPI.Application.Commands.Request.ProductRequest
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string? Id { get; set; }
    }
}
