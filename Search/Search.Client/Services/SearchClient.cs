using Nest;
using Search.Common.Models;
using System.Collections.Generic;

namespace Search.Client.Services
{
    public abstract class SearchClient
    {
        private readonly ElasticClient _elasticClient;
        
        public SearchClient(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        protected virtual WriteResponseBase Index<T>(T document)
            where T : class
        {
            var response = _elasticClient.CreateDocument(document);
            if (response.IsValid)
                return response;

            var path = new DocumentPath<T>(document);
            var request = new UpdateRequest<T, T>(document);
            var id = new Id(document);
                
            return _elasticClient.Update(DocumentPath<T>.Id(id), i => i.Doc(document));
        }

        protected virtual ISearchResponse<T> Search<T>(string query, int maximumHits = 10, List<ISort> sort = null)
            where T : class
        {
            var request = new SearchRequest<T>
            {
                Size = maximumHits,
                Sort = sort,
                Query = new QueryStringQuery
                {
                    Query = query,
                    AllowLeadingWildcard = true
                }
            };

            return _elasticClient.Search<T>(request);
        }
    }
}
