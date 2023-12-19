using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OIdify.Connect.Default;

namespace OIdify;
public static class OIdifyExtension
{
    public static IApplicationBuilder UseOIdify(this IApplicationBuilder app, Action<OIdifyOptions> setupAction = null)
    {
        using var scope = app.ApplicationServices.CreateScope();

        OIdifyOptions options = scope.ServiceProvider.GetRequiredService<IOptionsSnapshot<OIdifyOptions>>().Value;

        setupAction?.Invoke(options);

        return app.UseOIdify(options);
    }
    public static IApplicationBuilder UseOIdify(this IApplicationBuilder app, OIdifyOptions options)
    {
        return app.UseMiddleware<OIdifyMiddleware>(options);
    }
}
