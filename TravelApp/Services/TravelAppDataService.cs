using System.Net.Http.Json;
using TravelApp.Models.TravelAppData;

namespace TravelApp.TravelAppData
{
    public class TravelAppDataService: ITravelAppDataService
    {
        private readonly HttpClient _http;

        public TravelAppDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SelectedArticlesType>> GetSelectedArticles()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-selected-articles-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SelectedArticlesType>>().ConfigureAwait(false);
            }

            return new List<SelectedArticlesType>();
        }

        public async Task<List<DestinationsType>> GetDestinations()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-destinations-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<DestinationsType>>().ConfigureAwait(false);
            }

            return new List<DestinationsType>();
        }

        public async Task<List<ImageSet1Type>> GetImageSet1()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-image-set1-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ImageSet1Type>>().ConfigureAwait(false);
            }

            return new List<ImageSet1Type>();
        }

        public async Task<List<ImageSet2Type>> GetImageSet2()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-image-set2-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ImageSet2Type>>().ConfigureAwait(false);
            }

            return new List<ImageSet2Type>();
        }

        public async Task<List<ArticlesSource1Type>> GetArticlesSource1()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-articles-source1-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ArticlesSource1Type>>().ConfigureAwait(false);
            }

            return new List<ArticlesSource1Type>();
        }

        public async Task<List<ArticlesSource2Type>> GetArticlesSource2()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-articles-source2-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ArticlesSource2Type>>().ConfigureAwait(false);
            }

            return new List<ArticlesSource2Type>();
        }

        public async Task<List<ArticlesSource3Type>> GetArticlesSource3()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-articles-source3-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ArticlesSource3Type>>().ConfigureAwait(false);
            }

            return new List<ArticlesSource3Type>();
        }

        public async Task<List<ArticlesSource4Type>> GetArticlesSource4()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/travel-app-data-articles-source4-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ArticlesSource4Type>>().ConfigureAwait(false);
            }

            return new List<ArticlesSource4Type>();
        }
    }
}
