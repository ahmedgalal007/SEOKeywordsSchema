using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument.NoteDigitalDocument;
public class NoteDigitalDocument : DigitalDocument
{
    public override string TypeName { get; protected set; } = nameof(NoteDigitalDocument);
}
