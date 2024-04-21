using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObjects;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<ImageObject>))]
public class ImageObject : BaseEntity
{
    public virtual string TypeName { get; protected set; } = nameof(ImageObject);
    public virtual MediaObject Parent { get; protected set;}
}
