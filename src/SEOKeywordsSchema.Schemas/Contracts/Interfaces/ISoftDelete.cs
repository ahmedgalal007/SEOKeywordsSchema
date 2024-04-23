namespace SEOKeywordsSchema.Schemas.Contracts.Interfaces;

public interface ISoftDelete
{
    DateTime? DeletedOn { get; set; }
    DefaultIdType? DeletedBy { get; set; }
}