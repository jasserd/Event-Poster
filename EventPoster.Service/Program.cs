using EventPoster.Service.IoC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

SwaggerConfigurator.ConfigureServices(builder.Services);
SerilogConfigurator.ConfigureService(builder);
DbContextConfigurator.ConfigureServices(builder);

var app = builder.Build();

SwaggerConfigurator.ConfigureApplication(app);
SerilogConfigurator.ConfigureApplication(app);
DbContextConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();

app.Run();