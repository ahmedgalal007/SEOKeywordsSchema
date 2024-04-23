using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class LandmarksOrHistoricalBuildings : Place
{
    public override string TypeName { get; protected set; } = nameof(LandmarksOrHistoricalBuildings);
}
