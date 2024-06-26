﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<CreativeWork>))]
public class CreativeWork : BaseSchemaEntity, ISchemaEntity, IValuesMember<CreativeWork>
{
    public virtual string TypeName { get; protected set; } = nameof(CreativeWork);
    public string SchemaType { get; set; }
    public Thing? Parent { get; set; }
    public CreativeWork? Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    DefaultIdType IValuesMember<DefaultIdType, CreativeWork>.Id { get; set; }

    public CreativeWork Delete(DefaultIdType id)
    {
        return this;
    }

    public Boolean Equals(IValuesMember<DefaultIdType, CreativeWork>? other)
    {
        throw new NotImplementedException();
    }

    public bool IsLeafe()
    {
        return false;
    }

    public CreativeWork Update(CreativeWork value)
    {
        return this;
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