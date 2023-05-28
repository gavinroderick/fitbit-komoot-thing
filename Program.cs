var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/", (string? verify, FitbitPayload payload) =>
{
    if(!string.IsNullOrEmpty(verify)) return HandleVerification(verify);
    return Results.Ok(payload);
});

app.Run();

IResult HandleVerification(string queryParameter)
{
    if(queryParameter == "correctVerificationCode") return Results.NoContent();
    if(queryParameter == "incorrectVerificationCode") return Results.NotFound();
    return Results.BadRequest();
}

internal record FitbitPayload (string Id);
