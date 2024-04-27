using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType.CassetteFormat;
public class CassetteFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(CassetteFormat);
}
