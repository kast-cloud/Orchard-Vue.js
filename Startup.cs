using Lombiq.VueJs.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Descriptors.ShapeTemplateStrategy;
using OrchardCore.ResourceManagement;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;

namespace Lombiq.VueJs
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();

            services.AddScoped<IShapeTemplateHarvester, VueComponentTemplateHarvester>();
        }
    }
}
