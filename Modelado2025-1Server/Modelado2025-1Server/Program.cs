using Modelado2025_1.Servicio.ServiciosHttp;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Modelado2025_1BD.Datos;
using Modelado2025_1Repositorio.Repositorios;
using Modelado2025_1Server.Client.Pages;
using Modelado2025_1Server.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7230/")
});
// Add services to the container.

#region Construccion
builder.Services.AddScoped<IHttpServicio, HttpServicio>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Modelado2025-1 API",
        Version = "v1",
        Description = "API de gestión de Provincias",
    });
});
var StrConn = builder.Configuration.GetConnectionString("ConSql")
                                 ?? throw new InvalidOperationException(
                                    "El string de conexion no existe.");
builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(StrConn));

builder.Services.AddScoped<IDetallePedidoRepositorio, DetallePedidoRepositorio>();
builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();


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
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Modelado2025-1 API v1");
        c.RoutePrefix = "swagger"; // Swagger en /swagger
    });
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Modelado2025_1Server.Client._Imports).Assembly);

app.MapControllers();

#endregion+


app.Run();
