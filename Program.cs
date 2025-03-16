var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hey, this linne from from the first Middleware, I mean custom middleware");
});
app.Run();
