using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType.LaserDiscFormat;
public class LaserDiscFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(LaserDiscFormat);
}
