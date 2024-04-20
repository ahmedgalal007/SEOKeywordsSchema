using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalTrialDesign : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalTrialDesign);
}


// TODO Member DoubleBlindedTrial
// TODO Member InternationalTrial
// TODO Member MultiCenterTrial
// TODO Member OpenTrial
// TODO Member PlaceboControlledTrial
// TODO Member RandomizedTrial
// TODO Member SingleBlindedTrial
// TODO Member SingleCenterTrial
// TODO Member TripleBlindedTrial