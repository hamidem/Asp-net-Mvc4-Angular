
using System.Collections.Generic;

namespace NewsApp.Tools
{
    public static class Constants
    {
        public static string[] AllMediaName = { "Le Point", "L'Express", "La Croix",
                                                "Le Monde", "L'Express", "Courrier-International",
                                                "Le Monde", "Le Point", "Courrier-International",
                                                "Le Point", "L'Equipe", "Sport.fr" };

        public static string[] ActuMediaName = { "Le Point", "L'Express", "La Croix",
                                                 "Courrier-International"};

        public static string[] ScienceMediaName = { "L'Express", "Courrier-International" };

        public static string[] CultureMediaName = { "Le Point", "Courrier-International" };

        public static string[] SportMediaName = { "Le Point", "L'Equipe", "Sport.fr" };

        public static List<string[]> MediaNameList = new List<string[]>
        {
            ActuMediaName, ScienceMediaName, CultureMediaName, SportMediaName
        };

        /*Tableaux de toutes les urls*/
        public static List<string> UrlList = new List<string>
        {
            "http://www.lepoint.fr/24h-infos/rss.xml",
            "http://www.lexpress.fr/rss/alaune.xml",
            "http://www.la-croix.com/RSS/UNIVERS",
            "http://www.lemonde.fr/sciences/rss_full.xml",
            "http://www.lexpress.fr/rss/science-et-sante.xml",
            "http://www.courrierinternational.com/feed/category/6268/rss.xml",
            "http://www.lemonde.fr/culture/rss_full.xml",
            "http://www.lepoint.fr/culture/rss.xml",
            "http://www.courrierinternational.com/feed/category/6270/rss.xml",
            "http://www.lepoint.fr/sport/rss.xml",
            "http://www.lequipe.fr/rss/actu_rss.xml",
            "http://www.sports.fr/fr/cmc/rss.xml"
        };
        
        /*Tableaux des noms et urls des médias (Actualités)*/
        public static List<string> ActuUrlList = new List<string>
        {
            "http://www.lepoint.fr/24h-infos/rss.xml",
            "http://www.lexpress.fr/rss/alaune.xml",
            "http://www.la-croix.com/RSS/UNIVERS",
            "http://www.courrierinternational.com/feed/category/6260/rss.xml"
        };

        /*Tableaux des noms et urls des médias (science)*/
        public static List<string> ScienceUrlList = new List<string>
        {
           "http://www.lexpress.fr/rss/science-et-sante.xml",
           "http://www.courrierinternational.com/feed/category/6268/rss.xml"
        };

        /*Tableaux des noms et urls des médias (Culture)*/
        public static List<string> CultureUrlList = new List<string>
        {
            "http://www.lepoint.fr/culture/rss.xml",
            "http://www.courrierinternational.com/feed/category/6270/rss.xml"
        };

        /*Tableaux des noms et urls des médias (Sport)*/
        public static List<string> SportUrlList = new List<string>
        {
            "http://www.lepoint.fr/sport/rss.xml",
            "http://www.lequipe.fr/rss/actu_rss.xml",
            "http://www.sports.fr/fr/cmc/rss.xml"
        };
    }
}
