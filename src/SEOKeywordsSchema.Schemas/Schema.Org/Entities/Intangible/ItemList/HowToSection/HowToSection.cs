using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ItemList;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ItemList.HowToSection;
public class HowToSection : ItemList
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}
