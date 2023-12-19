namespace OIdify;
public class OIdifyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly OIdifyOptions _options;
    public OIdifyMiddleware(RequestDelegate next, OIdifyOptions options)
    {
        _next = next;
        _options = options;
    }
    public async Task Invoke(HttpContext httpContext)
    {
        await _next(httpContext);
    }

}
