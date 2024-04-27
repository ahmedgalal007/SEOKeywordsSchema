using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<AlternateName>))]
public class AlternateName : Text, ISchemaProperty<AlternateName>
{
    protected AlternateName() : base() { }
    public AlternateName(string value) : base(value)
    {

    }
    public AlternateName(Text text) : base(text.Value)
    {

    }
    public static bool operator ==(AlternateName type, string str)
    {
        return type.Equals(str);
    }
    public static bool operator !=(AlternateName type, string str)
    {
        return !type.Equals(str);
    }

}
