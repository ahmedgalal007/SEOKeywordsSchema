﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.TextObject;

[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<TextObject>))]
public class TextObject : BaseSchemaEntity, IValuesMember<TextObject>
{
    public TextObject? Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // public override string TypeName { get; protected set; } = nameof(TextObject);
    // public TextObject? Value { get; set; }
    // DefaultIdType IValuesMember<DefaultIdType, TextObject>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public TextObject Delete(DefaultIdType id)
    {
        return this;
    }

    public Boolean Equals(IValuesMember<DefaultIdType, TextObject>? other)
    {
        throw new NotImplementedException();
    }

    public TextObject Update(TextObject value)
    {
        return this;
    }
}
