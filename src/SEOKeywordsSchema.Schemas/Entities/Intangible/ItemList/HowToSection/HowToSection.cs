using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.ItemLists;
public class HowToSection : ItemList
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}
