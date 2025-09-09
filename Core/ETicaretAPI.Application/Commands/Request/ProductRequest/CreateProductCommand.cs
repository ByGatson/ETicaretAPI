using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Commands.Request.ProductRequest
{
    public class CreateProductCommand : Product, IRequest<bool> { }
}
