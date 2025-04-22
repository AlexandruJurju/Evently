using Evently.Modules.Events.Api.Database;
using Evently.Modules.Events.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Evently.Api.Extensions;

internal static class MigrationExtensions
{
    internal static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using EventsDbContext dbContext =
            scope.ServiceProvider.GetRequiredService<EventsDbContext>();

        dbContext.Database.Migrate();
    }
}
