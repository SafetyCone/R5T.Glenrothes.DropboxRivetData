using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Findhorn.DropboxRivet;
using R5T.Glenrothes.Findhorn;
using R5T.Lombardy.Standard;
using R5T.Zografou.Standard;


namespace R5T.Glenrothes.DropboxRivetData
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTestingDataDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<ITestingDataDirectoryPathProvider, DataDirectoryTestingDataDirectoryPathProvider>()
                .AddDataDirectoryPathProvider()
                .AddTestingDataDiretoryNameConvention()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
