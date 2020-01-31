using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Findhorn.DropboxRivet;
using R5T.Glenrothes.Findhorn;
using R5T.Lombardy.Standard;
using R5T.Zografou.Standard;


namespace R5T.Glenrothes.DropboxRivetData
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddTestingDataDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddDataDirectoryTestingDataDirectoryPathProvider(
                services.AddDataDirectoryPathProviderAction(),
                services.AddTestingDataDiretoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryPathProvider> AddTestingDataDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryPathProvider>(() => services.AddTestingDataDirectoryPathProvider());
            return serviceAction;
        }
    }
}
