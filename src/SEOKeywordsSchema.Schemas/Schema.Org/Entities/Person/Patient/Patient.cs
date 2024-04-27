using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Persons;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Persons.Patient;
public abstract class Patient : Person
{
    public override string TypeName { get; protected set; } = nameof(Patient);
}
