using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Entities;
using SEOKeywordsSchema.Schemas.Entities.Actions.AssessActions;
using SEOKeywordsSchema.Schemas.Entities.Actions.InteractActions;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks.CreativeWorkSerieses;

namespace SEOKeywordsSchema.Schemas.Enumerators;
public abstract partial class EnumSchemaProperties : Enumeration<EnumSchemaProperties>
{
    /* 01 */ public static readonly EnumSchemaProperties AdditionalType = new CharacterAttributeProperty();
    /* 01 */ public static readonly EnumSchemaProperties CharacterAttribute = new CharacterAttributeProperty();
    /* 02 */ public static readonly EnumSchemaProperties About = new AboutProperty();
    /* 03 */ public static readonly EnumSchemaProperties ActionOption = new ActionOptionProperty();
    /* 04 */ 
    /* 20 */ public static readonly EnumSchemaProperties Option = new OptionProperty();
    private EnumSchemaProperties(int value, string name)
        : base(value, name)
    {
    }

    public abstract List<Type> AcceptTypes { get; }
    public abstract List<Type> UsedInSchemas { get; }
    public virtual List<Type>? SubProperties { get; }
    public virtual List<EnumSchemaProperties>? Supersedes { get; }
    public virtual List<EnumSchemaProperties>? SupersededBy { get; }
    public virtual URL? Source { get; }


    private sealed class AdditionalTypeProperty : EnumSchemaProperties
    {
        public AdditionalTypeProperty()
            : base(1, "AdditionalType")
        {
        }

        public override List<Type> AcceptTypes => new() {
            typeof(Text),
            typeof(URL),
        };

        public override List<Type> UsedInSchemas => new() {
            typeof(Thing),
        };
    }

    private sealed class AboutProperty : EnumSchemaProperties
    {
        public AboutProperty()
            : base(1, "About")
        {
        }

        public override List<Type> AcceptTypes => new() {
            typeof(Thing)
        };

        public override List<Type> UsedInSchemas => new() {
            typeof(Certification),
            typeof(CommunicateAction),
            typeof(CreativeWork),
            typeof(Event)
        };

        public override URL Source => new URL("https://github.com/schemaorg/schemaorg/issues/1670");

    }

    private sealed class ActionOptionProperty : EnumSchemaProperties
    {
        public ActionOptionProperty()
            : base(2, "ActionOption")
        {
        }

        public override List<Type> AcceptTypes => new() {
            typeof(Text),
            typeof(Thing)
        };

        public override List<Type> UsedInSchemas => new() {
            typeof(ChooseAction),
        };

        public override List<EnumSchemaProperties> Supersedes => new() { Option };
    }

    private sealed class CharacterAttributeProperty : EnumSchemaProperties
    {
        public CharacterAttributeProperty()
            : base(4, "CharacterAttribute")
        {
        }

        public override List<Type> AcceptTypes => new() {
            typeof(Thing)
        };

        public override List<Type> UsedInSchemas => new() {
            typeof(Game),
            typeof(VideoGameSeries)
        };
        public override List<Type>? SubProperties => null;
        public override URL? Source => null;

        public override List<EnumSchemaProperties> Supersedes => new();

        public override List<EnumSchemaProperties> SupersededBy => new();
    }

    private sealed class OptionProperty : EnumSchemaProperties
    {
        public OptionProperty()
            : base(20, "Option")
        {
        }

        public override List<Type> AcceptTypes => new() {
            typeof(Text),
            typeof(Thing)
        };

        public override List<Type> UsedInSchemas => new() {
            typeof(ChooseAction),
        };
        public override List<EnumSchemaProperties> SupersededBy => new() { ActionOption };
    }
}
