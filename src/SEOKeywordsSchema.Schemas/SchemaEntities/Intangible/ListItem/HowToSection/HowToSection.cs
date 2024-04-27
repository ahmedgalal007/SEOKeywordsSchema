using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.ListItems;
public class HowToSection : ListItem
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}
