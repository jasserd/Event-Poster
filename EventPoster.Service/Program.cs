using EventPoster.Service.IoC;

var builder = WebApplication.CreateBuilder(args);

SwaggerConfigurator.ConfigureServices(builder.Services);
SerilogConfigurator.ConfigureService(builder);

var app = builder.Build();

SwaggerConfigurator.ConfigureApplication(app);
SerilogConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();

app.Run();