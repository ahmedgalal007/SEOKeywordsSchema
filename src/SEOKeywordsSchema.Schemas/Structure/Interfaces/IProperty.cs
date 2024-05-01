using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Structure.Interfaces;
internal interface IProperty
{
    Type PropertyType { get; }
    public string Name { get; set; }
    public List<IClass> DomainIncludes { get; set; }
    public List<IClass>? RangeIncludes { get; set; }

    // Class  or Enumeration or Property
    public List<IType>? SupersededBy { get; set; } 
    public bool IsSingleValue { get; set; }

    // Rule: Must be one or more instance of the Domains
    public List<IPropertyValue> PropertyValues { get; set; } 
    public IProperty InverseOf { get; set; }

}
