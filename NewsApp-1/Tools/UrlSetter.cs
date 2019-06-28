using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Tools
{
    public class UrlSetter
    {
        public List<string> SetUrlList(int categorie, int index)
        {
            List<string> urlList = new List<string>();
            switch (categorie)
            {
                case 2:
                    if (index >= 0)
                        urlList.Add(Constants.ScienceUrlList.ElementAt(index));
                    else
                        urlList.AddRange(Constants.ScienceUrlList);
                    break;
                case 3:
                    if (index >= 0)
                        urlList.Add(Constants.CultureUrlList.ElementAt(index));
                    else
                        urlList.AddRange(Constants.CultureUrlList);
                    break;
                case 4:
                    if (index >= 0)
                        urlList.Add(Constants.SportUrlList.ElementAt(index));
                    else
                        urlList.AddRange(Constants.SportUrlList);
                    break;
                case 5:
                    urlList.AddRange(Constants.UrlList);
                    break;
                default:
                    if (index >= 0)
                        urlList.Add(Constants.ActuUrlList.ElementAt(index));
                    else
                        urlList.AddRange(Constants.ActuUrlList);
                    break;
            }

            return urlList;
        }

        public List<List<string>> SetAllUrlList()
        {
            List<List<string>> urlList = new List<List<string>>();

            urlList.Add(Constants.ActuUrlList);
            urlList.Add(Constants.ScienceUrlList);
            urlList.Add(Constants.CultureUrlList);
            urlList.Add(Constants.SportUrlList);

            return urlList;
        }
    }
}
