using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.NewsArticle;
public class NewsArticle : Article
{
    public override string TypeName { get; protected set; } = nameof(NewsArticle);
}



// TODO AnalysisNewsArticle
// TODO AskPublicNewsArticle
// TODO BackgroundNewsArticle
// TODO OpinionNewsArticle
// TODO ReportageNewsArticle
// TODO ReviewNewsArticle