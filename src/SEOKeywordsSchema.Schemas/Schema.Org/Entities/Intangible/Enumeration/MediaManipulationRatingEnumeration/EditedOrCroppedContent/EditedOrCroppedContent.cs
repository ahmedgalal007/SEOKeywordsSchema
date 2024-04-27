using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MediaManipulationRatingEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MediaManipulationRatingEnumeration.EditedOrCroppedContent;
public class EditedOrCroppedContent : MediaManipulationRatingEnumeration
{
    public override string TypeName { get; protected set; } = nameof(EditedOrCroppedContent);
}
