using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SEOKeywordsSchema.Schemas.Things.CreativeWorks.Articles;

namespace Host.Persistence.Configurations.CreativeWorks;

public class NewsArticleConfig : IEntityTypeConfiguration<NewsArticle>
{
    public void Configure(EntityTypeBuilder<NewsArticle> builder)
    {
       
    }
}
