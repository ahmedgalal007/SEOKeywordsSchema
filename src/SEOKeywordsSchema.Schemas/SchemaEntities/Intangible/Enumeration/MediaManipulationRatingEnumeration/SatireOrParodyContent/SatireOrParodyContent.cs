using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MediaManipulationRatingEnumerations;
public class SatireOrParodyContent : MediaManipulationRatingEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SatireOrParodyContent);
}
