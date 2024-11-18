using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using FersaTech.Server.Utils.Interfaces;
using FersaTech.Server.Utils.Respository;
using FersaTech.Services.Database.Service.Interfaces;
using FersaTech.Services.Database.Service.Respositories;
using FersaTech.Services.File.Service.Interfaces;
using FersaTech.Services.File.Service.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DI SQL manager context
builder.Services.AddDbContext<ApplicationDbContext>(
    opttions => opttions.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsAssembly("FersaTech.Server")
        )
);

// Add services to the container., 
builder.Services.AddScoped(typeof(IDbManager<>), typeof(DbManager<>));
builder.Services.AddScoped<IMovementTypeRespository, MovementTypeRespository>();
builder.Services.AddScoped<IFileUtilRepository, FileUtilRepository>();
builder.Services.AddScoped<IFileExcelRepository, FileExcelRepository>();
builder.Services.AddScoped<ITransaccionesRepository, TransaccionesRepository>();
builder.Services.AddScoped<ITransaccionesDetalleRepository, TransaccionesDetalleRepository>();
builder.Services.AddScoped<IAlertasRepository, AlertasRepository>();
builder.Services.AddScoped<IBitacoraIncidenciasRepository, BitacoraIncidenciasRepository>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Add cors
app.UseCors(options =>

    options.WithOrigins("http://localhost:7202/")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowAnyOrigin()
);

//End cors

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
