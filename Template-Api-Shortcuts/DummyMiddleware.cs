using System.Globalization;

namespace Template_Api_Shortcuts
{
    public class DummyMiddleware
    {
        private readonly RequestDelegate _next;

        public DummyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("The Dummy Middleware is invoked");
            await _next(context);
        }
    }
}

