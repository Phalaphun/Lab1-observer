using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_observer
{
    internal class Publisher
    {
        int magNumber = 0;
        int targetNumberOfArticles = 4;
        List<Article> newArticles = new List<Article>();
        Magazine currentMagazine;

        List<Subscriber> subscribers = new List<Subscriber>();
        public void Subscribe(Subscriber newSubscriber)
        {
            if (subscribers.Contains(newSubscriber) == false)
                subscribers.Add(newSubscriber);
        }

        public void Unsubscribe(Subscriber remSubscriber)
        {
            if (subscribers.Contains(remSubscriber) == true)
                subscribers.Remove(remSubscriber);
        }

        public void NotifySubScribers()
        {
            foreach (Subscriber s in subscribers)
            {
                s.Update(this, currentMagazine);
            }
        }

        public void MainBuisnessLogic()
        {
            // Поиск материала
            // Написание статей
            if (newArticles.Count >= targetNumberOfArticles) // Выпуск журнала
            {
                magNumber++;
                currentMagazine = new Magazine(DateTime.Now, "Mag №" + magNumber, newArticles);
                NotifySubScribers();
                newArticles = new List<Article>();
            }
        }
        public void AddArticle(Article article)
        {
            newArticles.Add(article);
            MainBuisnessLogic();
        }


    }

}
