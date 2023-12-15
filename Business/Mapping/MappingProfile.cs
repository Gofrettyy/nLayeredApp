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
            CreateMap<DeleteCategoryRequest, Category>().ReverseMap();
            CreateMap<Category, DeletedCategoryResponse>().ReverseMap();
            CreateMap<UpdateCategoryRequest, Category>().ReverseMap();
            CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
            
            CreateMap<Product, GetListedProductResponse>().ForMember(destinationMember: 
                p => p.CategoryName,memberOptions: opt
                    => opt.MapFrom(p => p.Category.Name)).ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListedProductResponse>>().ReverseMap();

            CreateMap<GetListedCategoryResponse, Category>().ReverseMap();
            CreateMap<Paginate<GetListedCategoryResponse>, Paginate<Category>>().ReverseMap();
            
            
            
            
        }
    }
