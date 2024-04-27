using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Articles.NewsArticles;
public class ReviewNewsArticle : NewsArticle
{
    public override string TypeName { get; protected set; } = nameof(ReviewNewsArticle);
}
