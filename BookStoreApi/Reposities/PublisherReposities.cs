using BookStoreApi.Data;
using BookStoreApi.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Reposities
{
    public class PublisherReposities : IPublisherReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public PublisherReposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddPublisherAsync(string publisherName)
        {
            var publisher = _context.Publishers!.SingleOrDefault(m => m.PublisherName == publisherName);
            if (publisher == null)
            {
                var newPublisher = new Publisher()
                {
                    PublisherName = publisherName,
                };
                _context.Publishers!.Add(newPublisher);
                await _context.SaveChangesAsync();
                return newPublisher.PublisherId;

            }
            return 0;
           
        }

        public async Task <int> DeletePublisherAsync(int id)
        {
            var deletePublisher = _context.Publishers!.SingleOrDefault(m => m.PublisherId == id);
            var book = _context.Products!.FirstOrDefault(m => m.PublisherId == id);
            if (deletePublisher != null && book == null)
            {
                _context.Publishers!.Remove(deletePublisher);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<List<PublisherModel>> getAllPublisherAsync()
        {
            var publisher = await _context.Publishers!.ToListAsync();
            return _mapper.Map<List<PublisherModel>>(publisher);
        }

        public async Task<PublisherModel> getPublisherAsync(int id)
        {
            var publisher = await _context.Publishers!.FindAsync(id);
            return _mapper.Map<PublisherModel>(publisher);
        }

        public async Task UpdatePublisherAsync(int id, string publisherName)
        {
            var publisher = _context.Publishers!.SingleOrDefault(m => m.PublisherId == id);
            if (publisher != null)
            {
                publisher.PublisherName = publisherName;
                _context.Publishers!.Update(publisher);
                await _context.SaveChangesAsync();


            }
        }
    }
}
