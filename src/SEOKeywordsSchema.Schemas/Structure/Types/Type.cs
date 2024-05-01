using SEOKeywordsSchema.Schemas.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Structure.Types;
internal class Type : IType
{
    public IType[] SubClassOf { get; set; }
    public IProperty[] Properties { get; set; }
}
