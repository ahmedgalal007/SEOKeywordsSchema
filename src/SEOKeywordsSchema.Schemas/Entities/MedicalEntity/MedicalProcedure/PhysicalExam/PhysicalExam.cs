using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalProcedures;
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