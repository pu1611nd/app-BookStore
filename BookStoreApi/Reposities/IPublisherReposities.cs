using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface IPublisherReposities
    {
        public Task<List<PublisherModel>> getAllPublisherAsync();
        public Task<PublisherModel> getPublisherAsync(int id);
        public Task<int> AddPublisherAsync(string publisherName);

        public Task<int> DeletePublisherAsync(int id);

        public Task UpdatePublisherAsync(int id, string publisher);
    }
}
