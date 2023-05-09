using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface ICartItemPeposities
    {
        public List<CartItemOfMember> getAllCartItemOfCartAsync(string memberId);

        public Task<int> AddCartItemAsync(int Quantity,int bookId,string memberId);

        public Task DeleteCartItemAsync(int id);

        public Task<int> UpdateCartItemAsync(int id, int Quantity);
    }
}
