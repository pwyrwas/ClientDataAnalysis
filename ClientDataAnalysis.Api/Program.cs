using ClientDataAnalysis.Application;
using ClientDataAnalysis.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IntrastructureServiceCollection.AddServices(builder.Services);
ApplicationServiceCollection.AddServices(builder.Services);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

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

public partial class Program { }
