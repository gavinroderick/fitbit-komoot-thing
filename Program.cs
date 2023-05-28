var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/", (string verify) =>
{
    if(!string.IsNullOrEmpty(verify)) return HandleVerification(verify);
    return Results.Ok("S'all good");
});

app.Run();

IResult HandleVerification(string queryParameter)
{
    if(queryParameter == "correctVerificationCode") return Results.NoContent();
    if(queryParameter == "incorrectVerificationCode") return Results.NotFound();
    return Results.BadRequest();
}

