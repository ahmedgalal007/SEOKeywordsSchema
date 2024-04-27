using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.NewsArticle;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.NewsArticle.BackgroundNewsArticle;
public class BackgroundNewsArticle : NewsArticle
{
    public override string TypeName { get; protected set; } = nameof(BackgroundNewsArticle);
}
