using ETicaretAPI.Application.Commands.Request.ProductRequest;
using ETicaretAPI.Application.Queries.Handler.ProductHandler;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {

        private readonly IMediator mediatR;

        public ProductsController(IMediator mediatR)
        {
            this.mediatR = mediatR;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediatR.Send(new GetAllProductsQuery());
            return Ok(response);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await mediatR.Send(new GetByIdProductsQuery(id));
            return Ok(response);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand product)
        {
            var response = await mediatR.Send(product);
            return Ok(response);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand product)
        {
            var response = await mediatR.Send(product);
            return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await mediatR.Send(new DeleteProductCommand() { Id = id });
            return Ok(response);
        }

    }
}
