using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface IAuthorReposities
    {
        public Task<List<AuthorModel>> getAllAuthorAsync();
        public Task<AuthorModel> getAuthorAsync(int id);
        public Task<int> AddAuthorAsync(string authorName);

        public Task<int> DeleteAuthorAsync(int id);

        public Task UpdateAuthorAsync(int id, string authorName);
    }
}
