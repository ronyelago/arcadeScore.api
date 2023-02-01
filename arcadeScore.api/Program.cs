using arcadeScore.api.Data;
using arcadeScore.api.Repository;
using arcadeScore.api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<PartidaRepository, PartidaRepository>();
builder.Services.AddScoped<JogadorRepository, JogadorRepository>();
builder.Services.AddScoped<PontuacaoService, PontuacaoService>();
builder.Services.AddScoped<RankingService, RankingService>();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

FakeDatabase.GerarDadosEmMemoria();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
