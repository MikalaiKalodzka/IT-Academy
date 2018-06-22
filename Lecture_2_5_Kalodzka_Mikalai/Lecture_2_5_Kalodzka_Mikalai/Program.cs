using System;

namespace Lecture_2_5_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsOperator = new NewsOperator();

            var user1 = new ServiceSubscriber("Hendrik Larsson");

            var user2 = new ServiceSubscriber("Dobby");
            
            newsOperator.Subscribe(user1, NewsCategory.News);
            newsOperator.Subscribe(user1, NewsCategory.Humor);

            newsOperator.Subscribe(user2, NewsCategory.Sport);

            newsOperator.UnSubscribe(user1, NewsCategory.News);

            var todayNews = new News(NewsCategory.News, MessageToSend(NewsCategory.News));
            var todayWeather = new News(NewsCategory.Weather, MessageToSend(NewsCategory.Weather));
            var todaySport = new News(NewsCategory.Sport, MessageToSend(NewsCategory.Sport));
            var todayEvent = new News(NewsCategory.Events, MessageToSend(NewsCategory.Events));
            var todayHumor = new News(NewsCategory.Humor, MessageToSend(NewsCategory.Humor));
            var todayHumor1 = new News(NewsCategory.Humor, 
                "Interviewer: it says here you're extremely fast at maths, what's 30*17?\n" +
                "Me: 47\n" +
                "Interviewer: that's not even close\n" +
                "Me: yeah but it was quick\n");

            var todayHumor2 = new News(NewsCategory.Humor,
                "Father: Son, you were adopted.\n" +
                "Son: What?! I knew it! I want to meet my biological parents!\n" +
                "Father: We are your biological parents. Now pack up, the new ones will pick you up in 20 minutes.");
            
            newsOperator.AddNews(todayNews);
            newsOperator.AddNews(todayWeather);
            newsOperator.AddNews(todaySport);
            newsOperator.AddNews(todayEvent);
            newsOperator.AddNews(todayHumor);
            newsOperator.AddNews(todayHumor1);
            newsOperator.AddNews(todayHumor2);
            
            Console.ReadKey();
        }
        public static string MessageToSend(NewsCategory category)
        {
            switch (category)
            {
                case NewsCategory.News:
                    return "Some boring staff about combine operators.";

                case NewsCategory.Weather:
                    return "Let it rains. Probably.";
                    
                case NewsCategory.Sport:
                    return "Urgent News: It seems to be that Russians finally have learned " +
                        "how to play football. At least till the next qualification.";
                    
                case NewsCategory.Events:
                    return "Someone went somewhere, and another someone said about it something.";
                    
                case NewsCategory.Humor:
                    return "Mother: Am I a bad mother, Jane?\nDaughter: My name is Sarah.";
                    
                default:
                    return "Evidently something went wrong.";
            }
        }
    }
}
