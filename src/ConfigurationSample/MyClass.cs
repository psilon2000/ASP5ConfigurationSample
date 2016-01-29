using System;
using Microsoft.Extensions.OptionsModel;

namespace ConfigurationSample
{
    public class MyClass : IMyInterface
    {
        private readonly MyOptions _options;
        public MyClass(IOptions<MyOptions> options)
        {
            if (options?.Value == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            _options = options.Value;
        }

        public string GetOption()
        {
            return _options.AnyProperty;
        }
    }
}