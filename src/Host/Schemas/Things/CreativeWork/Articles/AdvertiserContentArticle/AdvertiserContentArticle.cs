using System;
using FSH.WebApi.Domain.Schemas.Things.CreativeWorks;

namespace Host.Schemas.Things.CreativeWork.Articles;
public class AdvertiserContentArticle : Article
{
    public override string TypeName { get; protected set; } = nameof(AdvertiserContentArticle);
}
