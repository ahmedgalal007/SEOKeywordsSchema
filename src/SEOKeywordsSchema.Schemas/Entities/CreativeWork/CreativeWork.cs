
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<CreativeWork>))]
public class CreativeWork : BaseSchemaEntity, ISchemaEntity
{
    public virtual string TypeName { get; protected set; } = nameof(CreativeWork);
    public String SchemaType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Thing? Parent { get; set; }
    public Boolean IsLeafe()
    {
        throw new NotImplementedException();
    }
}


// TODO AmpStory
// TODO ArchiveComponent
// TODO Article
// TODO Atlas
// TODO Blog
// TODO Book
// TODO Chapter
// TODO Claim
// TODO Clip
// TODO Collection
// TODO ComicStory
// TODO Comment
// TODO Conversation
// TODO Course
// TODO CreativeWorkSeason
// TODO CreativeWorkSeries
// TODO DataCatalog
// TODO Dataset
// TODO DefinedTermSet
// TODO Diet
// TODO DigitalDocument
// TODO Drawing
// TODO EducationalOccupationalCredential
// TODO Episode
// TODO ExercisePlan
// TODO Game
// TODO Guide
// TODO HowTo
// TODO HowToDirection
// TODO HowToSection
// TODO HowToStep
// TODO HowToTip
// TODO HyperToc
// TODO HyperTocEntry
// TODO LearningResource
// TODO Legislation
// TODO Manuscript
// TODO Map
// TODO MathSolver
// TODO MediaObject
// TODO MediaReviewItem
// TODO Menu
// TODO MenuSection
// TODO Message
// TODO Movie
// TODO MusicComposition
// TODO MusicPlaylist
// TODO MusicRecording
// TODO Painting
// TODO Photograph
// TODO Play
// TODO Poster
// TODO PublicationIssue
// TODO PublicationVolume
// TODO Quotation
// TODO Review
// TODO Sculpture
// TODO SheetMusic
// TODO ShortStory
// TODO SoftwareApplication
// TODO SoftwareSourceCode
// TODO SpecialAnnouncement
// TODO Statement
// TODO TVSeason
// TODO TVSeries
// TODO Thesis
// TODO VisualArtwork
// TODO WebContent
// TODO WebPage
// TODO WebPageElement
// TODO WebSite