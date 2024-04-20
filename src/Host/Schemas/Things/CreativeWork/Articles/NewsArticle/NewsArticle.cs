using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Articles;
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