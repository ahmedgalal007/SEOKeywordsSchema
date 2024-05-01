using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Structure.Interfaces;
internal interface IType
{
    public IType[] SubClassOf { get; set; }
    public IProperty[] Properties { get; set; }
}
