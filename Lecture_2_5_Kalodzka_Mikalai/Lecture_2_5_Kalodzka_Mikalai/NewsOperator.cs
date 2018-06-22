using System;

namespace Lecture_2_5_Kalodzka_Mikalai
{
    public delegate void NewsHandler(News news);

    public class NewsOperator
    {
        private event NewsHandler OnNewsOut;
        private event NewsHandler OnWeatherOut;
        private event NewsHandler OnSportsNewsOut;
        private event NewsHandler OnEventsOut;
        private event NewsHandler OnHumorOut;

        public void AddNews(News news)
        {
            if (news != null)
                switch (news.Category)
                {
                    case NewsCategory.News:
                        if(OnNewsOut != null)
                            OnNewsOut(news);                        
                        break;
                    case NewsCategory.Weather:
                        if(OnWeatherOut != null)
                            OnWeatherOut(news);
                        break;
                    case NewsCategory.Sport:
                        if(OnSportsNewsOut != null)
                            OnSportsNewsOut(news);
                        break;
                    case NewsCategory.Events:
                        if(OnEventsOut != null)
                            OnEventsOut(news);
                        break;
                    case NewsCategory.Humor:
                        if(OnHumorOut != null)
                            OnHumorOut(news);
                        break;
                    default:
                        break;
                }
            else
                throw new ArgumentNullException("news is null");
        }

        public void Subscribe(ServiceSubscriber subscriber, params NewsCategory[] category)
        {
            if (subscriber != null)
                foreach (var item in category)
                {
                    switch (item)
                    {
                        case NewsCategory.News:
                            OnNewsOut += subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Weather:
                            OnWeatherOut += subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Sport:
                            OnSportsNewsOut += subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Events:
                            OnEventsOut += subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Humor:
                            OnHumorOut += subscriber.OnNewsSend;
                            break;
                    }
                }        
        }
        
        public void UnSubscribe(ServiceSubscriber subscriber, params NewsCategory[] category)
        {
            if (subscriber != null)
                foreach (var item in category)
                {
                    switch (item)
                    {
                        case NewsCategory.News:
                            OnNewsOut -= subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Weather:
                            OnWeatherOut -= subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Sport:
                            OnSportsNewsOut -= subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Events:
                            OnEventsOut -= subscriber.OnNewsSend;
                            break;
                        case NewsCategory.Humor:
                            OnHumorOut -= subscriber.OnNewsSend;
                            break;
                    }
                }
        }
    }
}
