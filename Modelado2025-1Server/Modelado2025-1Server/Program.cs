using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1Server.Client.Pages;
using Modelado2025_1Server.Components;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

#region Construccion
var StrConn = builder.Configuration.GetConnectionString("ConSql");

builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(StrConn));

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
#endregion


var app = builder.Build();
// Configure the HTTP request pipeline.

#region Configuracion
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Modelado2025_1Server.Client._Imports).Assembly);

#endregion+


app.Run();
