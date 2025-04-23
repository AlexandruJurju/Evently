using Evently.Api;
using Evently.Api.Extensions;
using Evently.Common.Application;
using Evently.Common.Infrastructure;
using Evently.Modules.Events.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGenWithAuth();

builder.Services.AddApplication(
    [Evently.Modules.Events.Application.AssemblyReference.Assembly]
);

builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("Database")!);

builder.Services.AddEventsModule(builder.Configuration);

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });

    app.ApplyMigrations();
}

app.UseHttpsRedirection();

EventsModule.MapEndpoints(app);

app.Run();
