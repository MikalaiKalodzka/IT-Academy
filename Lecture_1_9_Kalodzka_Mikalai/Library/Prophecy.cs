namespace Library
{
    public struct Prophecy
    {

        public string Text { get; }

        public Interval Interval { get; }

        public Prophecy(Interval interval)
        {
            Interval = interval;
            switch (interval)
            {
                // TODO Nice =)
                case Interval.Today:
                    Text =  "Ваше предсказание на сегодня: внимательно следите за своими вложениями можете попасть в руки к аферистам.";
                    break;
                case Interval.Tomorrow:
                    Text = "Ваше предсказание на завтра: будущее вокруг вас слишком туманно, но мой третий глаз подсказывает мне, что вы познаете смысл жизни, но это неточно.";
                    break;
                case Interval.AfterWeek:
                    Text = "Ваше предсказание на следующую неделю: осталось 7 дней.";
                    break;
                case Interval.AfterMonth:
                    Text = "Ваше предсказание на следующий месяц: чтобы узнать, что ждет вас через месяц: вам следует прийти на еще один сеанс. И прихватите с собой больше денег, они создадут ауру прозрачности для моего ясновидения.";
                    break;
                default:
                    Text = "Уважаемый, мы тут вообще-то серьезными вещами занимаемся, так что не мешайте!";
                    break;
            }
        }

       
    }

}
