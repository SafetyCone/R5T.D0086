using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0064;


namespace R5T.D0086
{
    [ServiceDefinitionMarker]
    public interface IConfigurationConfigurer : IServiceDefinition
    {
        Task ConfigureConfiguration(IConfigurationBuilder configurationBuilder);
    }
}