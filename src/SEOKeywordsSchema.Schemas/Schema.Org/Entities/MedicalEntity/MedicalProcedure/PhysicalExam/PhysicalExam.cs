using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure.PhysicalExam;
public class PhysicalExam : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(PhysicalExam);
}

enum EnumPhysicalExam
{
    Abdomen,
    Appearance,
    CardiovascularExam,
    Ear,
    Eye,
    Genitourinary,
    Head,
    Lung,
    MusculoskeletalExam,
    Neck,
    Neuro,
    Nose,
    Skin,
    Throat,
}