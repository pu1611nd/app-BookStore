using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface IBookReposities
    {
        public Task<List<BookOfTitle>> getAllBookAsync(int page = 1);
        public Task<BookModel> getBookAsync(int id);
        public Task<int> AddBookAsync(BookAdd model);

        public Task<int> DeleteBookAsync(int id);

        public Task UpdateBookAsync(int id, BookModel bookModel);
        public Task<BookInfo> GetBookInfoAsync(int id);
        public List<BookOfTitle> GetAllBookOfTitleAsync(string title, int page = 1);
        public List<BookOfTitle> GetBookOfCatgoryAsync(int catgoryId, int page = 1);
        public List<BookOfTitle> GetRandomBook();
    }
}
