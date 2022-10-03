// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(e =>
{
    e.MapControllerRoute("default", "{controller}/{faction}");
})
app.Run();

