using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;
public class MedicalEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalEnumeration);
}



// TODO DrugCostCategory
// TODO DrugPregnancyCategory
// TODO DrugPrescriptionStatus
// TODO InfectiousAgentClass
// TODO MedicalAudienceType
// TODO MedicalDevicePurpose
// TODO MedicalEvidenceLevel
// TODO MedicalImagingTechnique
// TODO MedicalObservationalStudyDesign
// TODO MedicalProcedureType
// TODO MedicalSpecialty
// TODO MedicalStudyStatus
// TODO MedicalTrialDesign
// TODO MedicineSystem
// TODO PhysicalExam