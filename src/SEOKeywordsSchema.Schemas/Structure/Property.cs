using SEOKeywordsSchema.Schemas.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Structure;
internal class Property : IProperty
{
    public Type PropertyType => throw new NotImplementedException();

    public String Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public List<IClass> DomainIncludes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public List<IClass>? RangeIncludes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public List<IType>? SupersededBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Boolean IsSingleValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public List<IPropertyValue> PropertyValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public IProperty InverseOf { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
