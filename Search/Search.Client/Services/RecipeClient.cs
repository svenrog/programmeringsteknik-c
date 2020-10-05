using Nest;
using Search.Common.Models;
using System.Collections.Generic;

namespace Search.Client.Services
{
    public class RecipeClient : SearchClient
    {
        public RecipeClient(ElasticClient elasticClient) : base(elasticClient)
        {
            EnsureDefaultIndex(elasticClient);
        }

        public WriteResponseBase Index(RecipeDocument document)
        {
            return Index<RecipeDocument>(document);
        }

        public virtual ISearchResponse<RecipeDocument> Search(string query, int maximumHits = 10, List<ISort> sort = null)
        {
            return Search<RecipeDocument>(query, maximumHits, sort);
        }

        private void EnsureDefaultIndex(ElasticClient elasticClient)
        {
            var settings = elasticClient.ConnectionSettings;

            var indexExistResponse = elasticClient.Indices.Exists(settings.DefaultIndex);
            if (indexExistResponse.Exists)
                return;

            elasticClient.Indices.Create(settings.DefaultIndex,
                                         creationDescriptor => creationDescriptor.Map<RecipeDocument>(
                                             typeMapDescriptor => typeMapDescriptor.AutoMap<RecipeDocument>()));

        }
    }
}
