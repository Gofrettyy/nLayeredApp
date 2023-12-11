using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Mapping;


    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();
            //CreateMap<Product, GetListedProductResponse>().ReverseMap();
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Product, DeleteProductRequest>().ReverseMap();
            CreateMap<Product, DeletedProductResponse>().ReverseMap();
            CreateMap<Product, UpdateProductRequest>().ReverseMap();
            CreateMap<Product, UpdatedProductResponse>().ReverseMap();
            
            CreateMap<Product, GetListedProductResponse>().ForMember(destinationMember: 
                p => p.CategoryName,memberOptions: opt
                    => opt.MapFrom(p => p.Category.Name)).ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListedProductResponse>>().ReverseMap();
            
            CreateMap<Category, GetListedProductResponse>().ForMember(destinationMember: 
                c => c.ProductName,memberOptions: opt
                    => opt.MapFrom(c => c.Products)).ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListedProductResponse>>().ReverseMap();
            
            
            
            
        }
    }
