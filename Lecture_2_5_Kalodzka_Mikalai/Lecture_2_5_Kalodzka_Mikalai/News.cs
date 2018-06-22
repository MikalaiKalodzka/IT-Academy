namespace Lecture_2_5_Kalodzka_Mikalai
{
    public class News
    {
        public NewsCategory Category { get; }

        public string Message { get;  }

        public News(NewsCategory category, string message)
        {
            Category = category;
            Message = message;
        }       
    }
}