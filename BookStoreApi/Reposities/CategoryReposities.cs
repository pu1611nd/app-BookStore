using BookStoreApi  .Data;
using BookStoreApi.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Reposities
{
    public class CategoryReposities : ICategoryReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public CategoryReposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> AddCategoryAsync(string categoryName)
        {
            var category = _context.Categories!.SingleOrDefault(m => m.CategoryName == categoryName);
            if (category == null) 
            {
                var newCategory = new Category()
                {
                    CategoryName = categoryName,
                };
                _context.Categories!.Add(newCategory);
                await _context.SaveChangesAsync();
                return newCategory.CategoryId;
            }
            return 0;
            
        }

        public async Task<int> DeleteCategoryAsync(int id)
        {
            var deleteCategory = _context.Categories!.SingleOrDefault(m => m.CategoryId == id);
            var book = _context.Products!.FirstOrDefault(m => m.CategoryId == id);
            if (deleteCategory != null && book == null)
            {
                _context.Categories!.Remove(deleteCategory);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<List<CategoryModel>> getAllCategoryAsync()
        {
            var categories = await _context.Categories!.ToListAsync();
            return _mapper.Map<List<CategoryModel>>(categories);
        }

        public async Task<CategoryModel> getCategoryAsync(int id)
        {
            var category = await _context.Categories!.FindAsync(id);
            return _mapper.Map<CategoryModel>(category);
        }

        public async Task UpdateCategoryAsync(int id, string categoryName)
        {
 
             var category = _context.Categories!.SingleOrDefault(m => m.CategoryId == id);
             if (category != null)
                {
                    category.CategoryName = categoryName;
                    _context.Categories!.Update(category);
                    await _context.SaveChangesAsync();
                }

        }
    }
}
