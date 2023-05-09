using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface ICategoryReposities
    {
        public Task<List<CategoryModel>> getAllCategoryAsync();
        public Task<CategoryModel> getCategoryAsync(int id);
        public Task<int> AddCategoryAsync(string categoryName);

        public Task<int> DeleteCategoryAsync(int id);

        public Task UpdateCategoryAsync(int id, string categoryName);
    }
}
