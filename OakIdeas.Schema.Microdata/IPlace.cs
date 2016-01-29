using OakIdeas.Schema.Microdata.CreativeWorks;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;

namespace OakIdeas.Schema.Microdata
{
    public interface IPlace
    {
        PropertyValue AdditionalProperty { get; set; }
        PostalAddress Address { get; set; }
        AggregateRating AggregateRattings { get; set; }
        string BranchCode { get; set; }
        Place ContainedInPlace { get; set; }
        Place ContainsPlace { get; set; }
        Event Event { get; set; }
        string FaxNumber { get; set; }
        StructuredValue Geo { get; set; }
        string GlobalLocationNumber { get; set; }
        Map HasMap { get; set; }
        string IsicV4 { get; set; }
        ImageObject Logo { get; set; }
        OppeningHoursSpecification OpeningHoursSpecification { get; set; }
        Thing Photo { get; set; }
        Review Review { get; set; }
        string Telephone { get; set; }
    }
}