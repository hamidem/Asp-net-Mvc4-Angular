using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsApp.Tools;

namespace NewsApp.Models
{
    /// <summary>
    /// Represents a feed item.
    /// </summary>
    public class Item
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image_url { get; set; }
        public DateTime PublishDate { get; set; }
        public FeedType FeedType { get; set; }

        public Item()
        {
            Link = "";
            Title = "";
            Content = "";
            Image_url = "";
            PublishDate = DateTime.Today;
            FeedType = FeedType.RSS;
        }
    }
}