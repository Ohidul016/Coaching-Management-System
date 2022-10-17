using Serenity.Services;

namespace ConsoleProject.Administration
{
    public class TranslationListRequest : ListRequest
    {
        public string SourceLanguageID { get; set; }
        public string TargetLanguageID { get; set; }
    }
}