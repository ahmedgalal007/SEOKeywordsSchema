using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MusicReleaseFormatTypes;
public class DigitalFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(DigitalFormat);
}
