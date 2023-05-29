var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/", (string? verify, FitbitPayload payload) =>
{
    if(!string.IsNullOrEmpty(verify)) return HandleVerification(verify);
    return Results.Ok(payload);
});

app.Run();
const string verificationCode = "0d25592773aa1a6e5ed0f3763a960a386bbcdc813adfa29f71847602e9bd5177";
IResult HandleVerification(string queryParameter)
{
    if(queryParameter == verificationCode) return Results.NoContent();
    return Results.NotFound();
}

internal record FitbitPayload (string Id);
