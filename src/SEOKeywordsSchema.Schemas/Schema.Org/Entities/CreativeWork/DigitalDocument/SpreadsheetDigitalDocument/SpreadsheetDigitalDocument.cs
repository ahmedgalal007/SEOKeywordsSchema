using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument.SpreadsheetDigitalDocument;
public class SpreadsheetDigitalDocument : DigitalDocument
{
    public override string TypeName { get; protected set; } = nameof(SpreadsheetDigitalDocument);
}
