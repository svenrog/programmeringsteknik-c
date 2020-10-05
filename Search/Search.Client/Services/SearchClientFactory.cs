using Nest;
using Search.Client.Options;
using System;

namespace Search.Client.Services
{
    public static class SearchClientFactory
    {
        public static RecipeClient CreateClient(ConnectionOptions options)
        {
            return new RecipeClient(CreateElasticClient<RecipeClient>(options));
        }

        private static ElasticClient CreateElasticClient<T>(ConnectionOptions options)
            where T : class
        {
            var indexUri = new Uri(options.Host);
            var settings = new ConnectionSettings(indexUri)
            .DefaultIndex(options.Index)
            .DefaultMappingFor<T>(m => m
                .IndexName(options.Index)
            );

            return new ElasticClient(settings);
        }
    }
}
