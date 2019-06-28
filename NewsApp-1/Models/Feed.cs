using System;

namespace NewsApp.Models
{
    public class Feed
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image_url { get; set; }

        public DateTime LastUpdated { get; set; }

        public string Published { get; set; }

        public string Link { get; set; }

        public string Media_name { get; set; }
    }
}
