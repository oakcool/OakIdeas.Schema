namespace OakIdeas.Schema.Microdata.CreativeWorks.WebPages
{
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as breadcrumb may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page
    /// </summary>
    /// <see cref="http://www.schema.org/WebPage"/>
    public class WebPage : CreativeWork
    {
    }
}
