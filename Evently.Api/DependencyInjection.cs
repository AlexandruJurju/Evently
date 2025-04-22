using System.Reflection;

namespace Evently.Api;

internal static class DependencyInjection
{
    public static void AddSwaggerGenWithAuth(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

        services.AddSwaggerGen(options =>
        {
            options.CustomSchemaIds(id => id.FullName!.Replace('+', '-'));

            // Fix conflict for api versions
            options.ResolveConflictingActions(descriptions => descriptions.First());

            // Add xml comments
        });
    }
}
