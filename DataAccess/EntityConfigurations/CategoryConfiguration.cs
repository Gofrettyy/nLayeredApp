using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(b=>b.Id);
        
        builder.Property(b => b.Id ).HasColumnName("CategoryId").IsRequired(); 
        builder.Property(b => b.Name ).HasColumnName("CategoryName").IsRequired();
        builder.HasIndex(indexExpression: b => b.Name , name: "UK_Categories_CategoryName").IsUnique();//bu key ile işaretlenmiş alanlar veritabanında bir daha tekrar edemez.
        // fakat pk ilk oluşturulduğunda fiziksel bir alan oluşturulur veritabanında düzenlenirler ama uniq key sadece o alan default olarak oluşturulamaz demektir.
        builder.HasMany(b => b.Products); //bir kategorininin çok ürünü olabilir.
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);//benim bütün datama bu filtreyi ben sana hiç söylemeden uygula.Where deleteddate is null uygula demek.
    }
}