using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions;
public class BookmarkAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(BookmarkAction);
}
