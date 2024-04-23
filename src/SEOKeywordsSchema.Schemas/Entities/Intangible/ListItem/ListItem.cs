using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles;
public class ListItem : Intangible
{
    public override string TypeName { get; protected set; } = nameof(ListItem);
}


// TODO HowToDirection
// TODO HowToItem
// TODO HowToSection
// TODO HowToStep
// TODO HowToTip