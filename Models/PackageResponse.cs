using System;
using System.Collections.Generic;
using System.Text;

namespace UsageStatsApp.Models
{
    public class PackageResponse
    {
            public string title { get; set; }
            public string description { get; set; }
            public string descriptionHTML { get; set; }
            public string summary { get; set; }
            public string summaryHTML { get; set; }
            public string installs { get; set; }
            public int minInstalls { get; set; }
            public double score { get; set; }
            public int ratings { get; set; }
            public int reviews { get; set; }
            public List<int> histogram { get; set; }
            public int price { get; set; }
            public bool free { get; set; }
            public string currency { get; set; }
            public bool sale { get; set; }
            public object saleTime { get; set; }
            public object originalPrice { get; set; }
            public object saleText { get; set; }
            public bool offersIAP { get; set; }
            public object inAppProductPrice { get; set; }
            public string size { get; set; }
            public string androidVersion { get; set; }
            public string androidVersionText { get; set; }
            public string developer { get; set; }
            public string developerId { get; set; }
            public string developerEmail { get; set; }
            public string developerWebsite { get; set; }
            public object developerAddress { get; set; }
            public string privacyPolicy { get; set; }
            public string developerInternalID { get; set; }
            public string genre { get; set; }
            public string genreId { get; set; }
            public string icon { get; set; }
            public string headerImage { get; set; }
            public List<string> screenshots { get; set; }
            public object video { get; set; }
            public object videoImage { get; set; }
            public string contentRating { get; set; }
            public object contentRatingDescription { get; set; }
            public object adSupported { get; set; }
            public bool containsAds { get; set; }
            public string released { get; set; }
            public int updated { get; set; }
            public string version { get; set; }
            public string recentChanges { get; set; }
            public string recentChangesHTML { get; set; }
            public List<string> comments { get; set; }
            public bool editorsChoice { get; set; }
            public string appId { get; set; }
            public string url { get; set; }
        }
    
}
