using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using NewsApp.Models;
using NewsApp.Tools;


namespace NewsApp.Service
{
    public static class ArticleService
    {
        private static UrlSetter urlSetter = new UrlSetter();
        private static List<string> UrlList = new List<string>();

        public static Feed Feed { get; set; }
        public static List<Feed> feeds = new List<Feed>();
        public static Feed RandFeed { get; set; }

        public static List<Feed> FeedList { get; set; }

        public static void GetFeeds(int cat, int id)
        {
            FeedList = new List<Feed>();
            UrlList = urlSetter.SetUrlList(cat, id);

            foreach (var url in UrlList)
            {
                FeedParser parser = new FeedParser();
                var items = parser.Parse(url, FeedType.RSS);

                if (items != null)
                {
                    foreach (var item in items)
                    {
                        if (item != null && !string.IsNullOrEmpty(item.Title)
                        && !string.IsNullOrEmpty(item.Content))
                        {
                            string title = Regex.Replace(item.Title, "<.*?>", string.Empty);
                            string description = Regex.Replace(item.Content, "<.*?>", string.Empty);
                            string link = Regex.Replace(item.Link, "unsafe:        ", string.Empty).Trim();

                            Feed feed = new Feed
                            {
                                Media_name = Constants.MediaNameList.ElementAt(cat - 1).ElementAt(id),
                                Title = title,
                                Description = description,
                                Link = link,
                                Published = item.PublishDate.ToString("ddd d MMM yyyy",
                                              CultureInfo.CreateSpecificCulture("fr-FR")),
                                Image_url = item.Image_url
                            };

                            FeedList.Add(feed);
                        }
                    }
                }
            }
        }

        public static void GetAllFeeds()
        {
            FeedList = new List<Feed>();
            if (feeds.Count < 1)
            {
                int index = -1;
                UrlList = Constants.UrlList;
                foreach (var url in UrlList)
                {
                    index++;
                    FeedParser parser = new FeedParser();
                    var items = parser.Parse(url, FeedType.RSS);

                    if (items != null)
                    {
                        foreach (var item in items)
                        {
                            if (item != null && !string.IsNullOrEmpty(item.Title)
                            && !string.IsNullOrEmpty(item.Content))
                            {
                                string title = Regex.Replace(item.Title, "<.*?>", String.Empty);
                                string description = Regex.Replace(item.Content, "<.*?>", String.Empty);

                                feeds.Add(new Feed
                                {
                                    Media_name = Constants.AllMediaName.ElementAt(index),
                                    Title = title,
                                    Description = description,
                                    Link = item.Link,
                                    Published = item.PublishDate.ToString("ddd d MMM yyyy",
                                              CultureInfo.CreateSpecificCulture("fr-FR")),
                                    Image_url = item.Image_url
                                });
                            }
                        }
                    }
                }
                feeds.OrderByDescending(o => o.Published);
            }

            foreach (var feed in feeds)
            {
                Random ranId = new Random();
                var rand = RandomGen1.Next(feeds.Count());

                string title = Regex.Replace(feeds.ElementAt(rand).Title, "<.*?>", string.Empty);
                string description = Regex.Replace(feeds.ElementAt(rand).Description, "<.*?>", string.Empty);
                string link = Regex.Replace(feeds.ElementAt(rand).Link, "unsafe:        ", string.Empty).Trim();

                Feed = new Feed
                {
                    Media_name = feeds.ElementAt(rand).Media_name,
                    Title = title,
                    Description = description,
                    Link = link,
                    Published = feeds.ElementAt(rand).Published,
                    Image_url = feeds.ElementAt(rand).Image_url
                };

                FeedList.Add(Feed);
            }
        }
    }

    public static class RandomGen1
    {
        private static Random _inst = new Random();

        public static int Next(int v)
        {
            lock (_inst) return _inst.Next(0, v);
        }
    }
}
