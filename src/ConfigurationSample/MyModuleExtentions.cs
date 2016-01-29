using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigurationSample
{
    public static class MyModuleExtentions
    {
        public static void AddMyModule(this IServiceCollection services)
        {
            var module = new MyModule();
            module.Load(services);
        }
    }
}