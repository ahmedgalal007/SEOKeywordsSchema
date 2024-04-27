using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Url>))]
public class Url : List<URL>, ISchemaProperty<Url>
{
    protected Url() : base() { }
    protected Url(string url) : base(new List<URL> { new URL(url) }) { }
    protected Url(Text txt) : base(new List<URL> { new URL(txt.Value) }) { }
    protected Url(URL url) : base(new List<URL> { url }) { }
    protected Url(IEnumerable<URL> uRLs) : base(uRLs) { }
}
