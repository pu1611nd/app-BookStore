using AutoMapper;
using AutoMapper.Execution;
using BookStoreApi.Data;
using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookStoreApi.Reposities
{
    public class CartItemPeposities : ICartItemPeposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public CartItemPeposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       
        public async Task updateCartItem(int soluong,CartItem cartItem)
        {
            cartItem.Quantity = soluong;          
            _context.CartItems.Update(cartItem);
            await _context.SaveChangesAsync();
        }
        public async Task<int> AddCartItemAsync(int Quantity,int bookId,string memberId)
        {
            var book = _context.Products!.Find(bookId);
            var Carts= _context.Carts!.SingleOrDefault(pr => pr.MemberId == memberId);
          
            if (book.SoLuong > Quantity && Quantity >0)
            {
                var cartItem = _context.CartItems.SingleOrDefault(pr => pr.ProductId == bookId);
                if(cartItem != null) 
                { 
                    int soluong = cartItem.Quantity + Quantity;
                    updateCartItem(soluong, cartItem);
                    return 1;
                }
                var newCartItem = new CartItem
                {
                    ProductId = book.ProductId,
                    Quantity = Quantity,
                    CartId = Carts.CartId
                };
                _context.CartItems!.Add(newCartItem);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 2;
        }

        public async Task DeleteCartItemAsync(int id)
        {
            var deleteCartItem = _context.CartItems!.SingleOrDefault(m => m.Id == id);
            if (deleteCartItem != null)
            {
                _context.CartItems!.Remove(deleteCartItem);
                await _context.SaveChangesAsync();
            }
        }


        public List<CartItemOfMember> getAllCartItemOfCartAsync(string memberId)
        {
            var cart = _context.Carts.SingleOrDefault(pr => pr.MemberId.Contains(memberId));
            var CartItem = from c in _context.CartItems
                           join p in _context.Products on c.ProductId equals p.ProductId
                           where c.CartId == cart.CartId
                           select new CartItemOfMember
                           {
                                  CartItemId = c.Id,
                                  ProducId = c.ProductId,
                                  Quantity = c.Quantity,
                                  Price = p.Price,
                                  Title = p.Title,
                                  ImageUrl = p.ImageUrl,

                              };
           
            return CartItem.ToList();
        }

        public async Task<int> UpdateCartItemAsync(int id, int soluong)
        {
            var cartItem = _context.CartItems.SingleOrDefault(pr => pr.Id == id);
            var book = _context.Products.SingleOrDefault(pr => pr.ProductId == cartItem.ProductId);
            if(book.SoLuong > soluong && soluong > 0)
            {
                updateCartItem(soluong,cartItem);
                return 0;
            }else
            {
                return 1;
            }

        }
    }
}
