using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_observer
{
    internal class People : Subscriber
    {
        readonly public string Name;
        public People(string name)
        {
            Name = name;
        }

        public void Update(Publisher sender, Object context)
        {
            Magazine magazine = (Magazine)context;
            foreach (Article article in magazine.Articles)
                Read(article);
        }
        private void Read(Article article)
        {
            Console.WriteLine($"{Name} читает статью \"{article.Title}\"");
        }

    }
}
