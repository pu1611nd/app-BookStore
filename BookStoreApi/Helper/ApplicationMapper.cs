
using BookStoreApi.Data;
using BookStoreApi.Models;
using AutoMapper;

namespace  BookStoreApi.helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Product, BookModel>().ReverseMap();
            CreateMap<Product, BookAdd>().ReverseMap();

            CreateMap<Author, AuthorModel>().ReverseMap();

            CreateMap<Category, CategoryModel>().ReverseMap();

            CreateMap<Publisher, PublisherModel>().ReverseMap();

            CreateMap<CartItem, CartItemModel>().ReverseMap();

            CreateMap<Invoice, InvoiceModel>().ReverseMap();
            CreateMap<Invoice, InvoiceAdd>().ReverseMap();

            CreateMap<InvoiceDetail, DentailModel>().ReverseMap();

        }
    }
}
