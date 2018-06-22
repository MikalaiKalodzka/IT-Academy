using System;

namespace Lecture_2_5_Kalodzka_Mikalai
{
    public class ServiceSubscriber
    {
        public string UserName { get; set; }
        public ServiceSubscriber(string userName)
        {
            UserName = userName;
        }

        public void OnNewsSend( News news)
        {
            Console.WriteLine("User: {0} got new news.", UserName);
            Console.WriteLine("\n");
            Console.WriteLine(news.Message);
            Console.WriteLine("\n\n");
        }

        public void OnNewsSend(object sender, NewsEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
