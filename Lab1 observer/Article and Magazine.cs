using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_observer
{
    class Article
    {
        readonly public string Title;
        readonly public string Text;
        public Article(string title, string text)
        {
            Title = title;
            Text = text;
        }
    }
    class Magazine
    {
        readonly public DateTime PublishDate;
        readonly public string MainTitle;
        readonly public Article[] Articles;
        public Magazine(DateTime pubDate, string title, List<Article> articles)
        {
            PublishDate = pubDate;
            MainTitle = title;
            Articles = articles.ToArray();
        }
    }
}
