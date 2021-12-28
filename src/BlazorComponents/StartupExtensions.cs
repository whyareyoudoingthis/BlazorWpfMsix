using Blazorise;
using Blazorise.Icons.Material;
using Blazorise.Material;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddComponents(this IServiceCollection services) {
            services
                .AddBlazorise( options =>
                {
                    options.ChangeTextOnKeyPress = true; // optional
                } )
                .AddMaterialProviders()
                .AddMaterialIcons();
            return services;
        }
    }
}