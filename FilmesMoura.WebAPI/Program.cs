using FilmesMoura.WebAPI.BdContextFilme;
using FilmesMoura.WebAPI.Interfaces;
using FilmesMoura.WebAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o contexto do banco de dados
builder.Services.AddDbContext<FilmesContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();

//Adiciona servico de controle
builder.Services.AddControllers();

var app = builder.Build();

//Adiciona o mapeamento de controle
app.MapControllers();

app.Run();
