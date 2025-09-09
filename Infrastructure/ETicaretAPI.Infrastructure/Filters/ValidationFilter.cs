using Microsoft.AspNetCore.Mvc.Filters;

namespace ETicaretAPI.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
