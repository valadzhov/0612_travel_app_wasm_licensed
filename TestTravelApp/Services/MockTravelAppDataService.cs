using TravelApp.Models.TravelAppData;

namespace TravelApp.TravelAppData
{
    public class MockTravelAppDataService : ITravelAppDataService
    {
        public Task<List<SelectedArticlesType>> GetSelectedArticles()
        {
            return Task.FromResult<List<SelectedArticlesType>>(new());
        }

        public Task<List<DestinationsType>> GetDestinations()
        {
            return Task.FromResult<List<DestinationsType>>(new());
        }

        public Task<List<ImageSet1Type>> GetImageSet1()
        {
            return Task.FromResult<List<ImageSet1Type>>(new());
        }

        public Task<List<ImageSet2Type>> GetImageSet2()
        {
            return Task.FromResult<List<ImageSet2Type>>(new());
        }

        public Task<List<ArticlesSource1Type>> GetArticlesSource1()
        {
            return Task.FromResult<List<ArticlesSource1Type>>(new());
        }

        public Task<List<ArticlesSource2Type>> GetArticlesSource2()
        {
            return Task.FromResult<List<ArticlesSource2Type>>(new());
        }

        public Task<List<ArticlesSource3Type>> GetArticlesSource3()
        {
            return Task.FromResult<List<ArticlesSource3Type>>(new());
        }

        public Task<List<ArticlesSource4Type>> GetArticlesSource4()
        {
            return Task.FromResult<List<ArticlesSource4Type>>(new());
        }
    }
}
