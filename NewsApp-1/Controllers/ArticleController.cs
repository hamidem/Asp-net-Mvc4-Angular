using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NewsApp.Models;
using NewsApp.Service;

namespace NewsApp.Controllers
{
    public class ArticleController : ApiController
    {
        public IEnumerable<Feed> Get()
        {
            ArticleService.GetAllFeeds();

            return Enumerable.Range(0, (int)ArticleService.FeedList?.Count).Select(index => new Feed
            {
                Media_name = ArticleService.FeedList?.ElementAt(index).Media_name,
                Title = ArticleService.FeedList?.ElementAt(index).Title,
                Description = ArticleService.FeedList?.ElementAt(index).Description,
                Image_url = ArticleService.FeedList?.ElementAt(index).Image_url,
                Published = ArticleService.FeedList?.ElementAt(index).Published,
                Link = ArticleService.FeedList?.ElementAt(index).Link
            }).ToList();
        }
        
        public IEnumerable<Feed> Get(int cat, int id)
        {
            ArticleService.GetFeeds(cat, id);

            return Enumerable.Range(0, (int)ArticleService.FeedList?.Count).Select(index => new Feed
            {
                Media_name = ArticleService.FeedList?.ElementAt(index).Media_name,
                Title = ArticleService.FeedList?.ElementAt(index).Title,
                Description = ArticleService.FeedList?.ElementAt(index).Description,
                Image_url = ArticleService.FeedList?.ElementAt(index).Image_url,
                Published = ArticleService.FeedList?.ElementAt(index).Published,
                Link = ArticleService.FeedList?.ElementAt(index).Link
            }).ToList();
        }
    }
}
