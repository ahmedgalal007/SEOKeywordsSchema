using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MusicReleaseFormatTypes;
public class DVDFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(DVDFormat);
}
