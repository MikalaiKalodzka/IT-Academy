using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_5_Kalodzka_Mikalai
{
    public interface INewsSubscriber
    {
        NewsCategory SubscibeCategories { get; }
        void OnNewsPublish(object sender, News news);
    }
}
