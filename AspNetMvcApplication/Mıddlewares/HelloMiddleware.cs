using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AspNetMvcApplication.Mıddlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next= next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            System.Console.WriteLine("SELAM BRO");
            await _next.Invoke(httpContext);
            System.Console.WriteLine("merhaba bro");
        }
    }
}
