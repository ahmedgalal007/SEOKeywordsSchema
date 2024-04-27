using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.QualitativeValue;
public class QualitativeValue : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(QualitativeValue);
}

// TODO BedType
// TODO DriveWheelConfigurationValue
// TODO SizeSpecification
// TODO SteeringPositionValue
