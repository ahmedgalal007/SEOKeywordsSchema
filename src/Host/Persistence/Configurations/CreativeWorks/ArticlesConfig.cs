using FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Articles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Host.Persistence.Configurations.CreativeWorks;

public class NewsArticleConfig : IEntityTypeConfiguration<NewsArticle>
{
    public void Configure(EntityTypeBuilder<NewsArticle> builder)
    {
       
    }
}
