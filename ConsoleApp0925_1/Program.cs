using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //날짜, 시각
            Console.WriteLine(DateTime.Now.ToShortDateString());    //날짜(하이픈)
            Console.WriteLine(DateTime.Now.ToLongDateString()); //날짜(년, 월, 일, 요일)

            DateTime to = DateTime.Now;
            DateTime from = new DateTime(1995, 7, 14);
            TimeSpan interval = to - from;  //날짜의 간격을 계산
            Console.WriteLine(interval.Days);   //일수

            string str = new DateTime(2018, 1, 24).AddYears(2).AddDays(-7).ToString("yyyy.MM.dd");  //Add -->> 추가
            Console.WriteLine(str);

            DateTime limit =  new DateTime(2020, 9, 26, 13, 0, 0);
            double rHour = (limit - DateTime.Now).TotalHours;   //시간
            Console.WriteLine(rHour);

            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            Console.WriteLine("1일 -->> " + start.ToShortDateString());
            Console.WriteLine("말일 -->> " + start.AddMonths(1).AddDays(-1).ToShortDateString());

            start = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1); //DayOfWeek -->> 요일
            Console.WriteLine("일요일 -->> " + start.ToShortDateString());
            Console.WriteLine("토요일 -->> " + start.AddDays(6).ToShortDateString());
        }
    }
}
