using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Collections;
public class ProductCollection: Collection
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}

