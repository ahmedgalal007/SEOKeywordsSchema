using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.ImageObject;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<ImageObject>))]
public class ImageObject : BaseEntity, IValuesMember<ImageObject>
{
    public virtual string TypeName { get; protected set; } = nameof(ImageObject);
    public virtual MediaObject Parent { get; protected set; }
    DefaultIdType IValuesMember<DefaultIdType, ImageObject>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ImageObject Delete(DefaultIdType id)
    {
        throw new NotImplementedException();
    }

    public ImageObject Update(ImageObject value)
    {
        throw new NotImplementedException();
    }
}
