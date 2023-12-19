namespace OIdify.Connect;
public class Authorize
{
    public static readonly string[] HttpMethodVerb = [HttpMethods.Get, HttpMethods.Post];
    public async Task<IResult> ProcessAsync()
    {
        await Task.CompletedTask;
        return Results.Ok();
    }

}