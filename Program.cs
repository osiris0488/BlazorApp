using BlazorApp.Services;
using MiBlazorApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio de base de datos SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios a la aplicación
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Registrar el servicio ICitaService
builder.Services.AddScoped<ICitaService, CitaService>();

var app = builder.Build();

// Configurar la aplicación
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
