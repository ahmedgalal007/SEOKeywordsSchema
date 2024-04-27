using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Places;
public class LandmarksOrHistoricalBuildings : Place
{
    public override string TypeName { get; protected set; } = nameof(LandmarksOrHistoricalBuildings);
}
