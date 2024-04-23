using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class TouristAttraction : Place
{
    public override string TypeName { get; protected set; } = nameof(TouristAttraction);
}
