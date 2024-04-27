using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Persons;
public abstract class Patient : Person
{
    public override string TypeName { get; protected set; } = nameof(Patient);
}
