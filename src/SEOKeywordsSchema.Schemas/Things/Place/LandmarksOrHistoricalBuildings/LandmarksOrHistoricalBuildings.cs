using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class LandmarksOrHistoricalBuildings : Place
{
    public override string TypeName { get; protected set; } = nameof(LandmarksOrHistoricalBuildings);
}
