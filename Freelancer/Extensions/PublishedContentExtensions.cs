
namespace Freelancer.Extensions
{
    public static class PublishedContentExtensions
    {
        public static HomePage? GetHomePage(this IPublishedContent publishedContent)
        {
            return publishedContent.AncestorOrSelf<HomePage>();
        }

        public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
        {
            var homePage = GetHomePage(publishedContent);
            return homePage?.FirstChild<SiteSettings>();
        }

        public static string? GetSiteName(this IPublishedContent publishedContent)
        {
            var homePage = GetHomePage(publishedContent);
            if (homePage == null) return null;

            // Attempt to find SiteSettings as a property or child
            var siteSettings = homePage.Value<IPublishedElement>("siteSettingsAlias");
            if (siteSettings == null) return null;

            // Access the SiteName property
            return siteSettings.Value<string>("siteName");
        }
    }
}