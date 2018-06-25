using System;
using System.Collections.Generic;

namespace Lecture_2_5_Kalodzka_Mikalai
{
    
    public class NewsOperatorV2
    {
        private readonly Dictionary<NewsCategory, EventHandler<NewsEventArgs>> _onFreshNewsEvent;

        public NewsOperatorV2()
        {
            _onFreshNewsEvent = new Dictionary<NewsCategory, EventHandler<NewsEventArgs>>();
        }

        //private EventHandler<NewsEventArgs>  OnNewsOut;
        //private EventHandler<NewsEventArgs>  OnWeatherOut;
        //private EventHandler<NewsEventArgs>  OnSportsNewsOut;
        //private EventHandler<NewsEventArgs>  OnEventsOut;
        //private EventHandler<NewsEventArgs>  OnHumorOut;

        public void AddNews(News news)
        {
            if(news == null) throw new ArgumentNullException("news is null");
            if(_onFreshNewsEvent.ContainsKey(news.Category)) 
                _onFreshNewsEvent[news.Category]?.Invoke(this, new NewsEventArgs { News = news});
        }

        public void Subscribe(ServiceSubscriber subscriber, params NewsCategory[] category)
        {
            foreach (var newsCategory in category)
                _onFreshNewsEvent[newsCategory] += subscriber.OnNewsSend;
        }

        public event EventHandler<NewsEventArgs> OnNewsAdded
        {
            add => ManageSubscription(value, true);
            remove => ManageSubscription(value, false);
        }

        private void ManageSubscription(EventHandler<NewsEventArgs> value, bool shouldAdd)
        {
            var subscriber = value.Target as INewsSubscriber;
            if(subscriber == null) return;

            foreach (var newsCategory in _onFreshNewsEvent.Keys)
                if (subscriber.SubscibeCategories.HasFlag(newsCategory))
                    if (shouldAdd)
                        _onFreshNewsEvent[newsCategory] += value;
                    else
                        _onFreshNewsEvent[newsCategory] -= value;
        }
    }
}
