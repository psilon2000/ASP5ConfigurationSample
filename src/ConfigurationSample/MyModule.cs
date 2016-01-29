using Microsoft.Extensions.DependencyInjection;

namespace ConfigurationSample
{
    public class MyModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddTransient<IMyInterface, MyClass>();
        }
    }
}