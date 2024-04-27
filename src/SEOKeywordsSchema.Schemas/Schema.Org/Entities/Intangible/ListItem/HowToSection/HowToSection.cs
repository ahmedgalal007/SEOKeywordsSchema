using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ListItem;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ListItem.HowToSection;
public class HowToSection : ListItem
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}
