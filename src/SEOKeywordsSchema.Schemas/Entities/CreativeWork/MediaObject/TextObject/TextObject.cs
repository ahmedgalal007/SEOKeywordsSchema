using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.MediaObjects;
public class TextObject : MediaObject, IValuesMember<TextObject>
{
    public override string TypeName { get; protected set; } = nameof(TextObject);
    DefaultIdType IValuesMember<DefaultIdType, TextObject>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public TextObject Delete(DefaultIdType id)
    {
        throw new NotImplementedException();
    }

    public TextObject Update(TextObject value)
    {
        throw new NotImplementedException();
    }
}
