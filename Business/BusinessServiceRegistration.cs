using System.Reflection;
using Business.Abtracts;
using Business.Concretes;
using Business.Rules;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class BusinessServiceRegistration 
{ 
    public static IServiceCollection AddBusinessServices(this IServiceCollection services) 
   {
       services.AddScoped<IProductService, ProductManager>();
       services.AddScoped<ICategoryService, CategoryManager>();
       services.AddScoped<CategoryBusinessRules>(); //bu şu demek biri bu classta instance isterse bu classın newini ver demek//scope her instance için bir
       services.AddScoped<ProductBusinessRules>();
    services.AddAutoMapper(Assembly.GetExecutingAssembly());
    
    return services;
    //ınstance üretmek demek otomatik newle demek
   }
    
}