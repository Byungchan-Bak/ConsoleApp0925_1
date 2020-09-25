using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925_1
{
    class String1
    {
        static void Main()
        {
            //
            string str1 = "가나다라마바사";

            Console.WriteLine(str1.Contains("가나"));
            Console.WriteLine(str1.Contains('가'));
            Console.WriteLine(str1.Contains("라마"));
            Console.WriteLine(str1.IndexOf("라마"));  //문자열의 위치

            //while (true)
            //{
            //    Console.Write("Email : ");
            //    string strEmail = Console.ReadLine();
            //    //bool check;



            //    /*
            //    do
            //    {
            //        Console.Write("Email : ");
            //        strEmail = Console.ReadLine();
            //        check = strEmail.Contains("@");
            //    } while (!check);
            //    */

            //    if (!strEmail.Contains("@")) { Console.WriteLine("유효한 메일이 아닙니다."); }
            //    if (strEmail.IndexOf("@") < 1) { Console.WriteLine("유효한 메일이 아닙니다."); }
            //}
            /*
            string birth = "";
            string sex = "";
            bool check = true;

            while (check)
            {
                Console.Write("주민등록번호 입력 : ");
                birth = Console.ReadLine();
                if (birth.Replace("-", "").Length == 13) { check = false; }
                else { check = true; }

                if (birth.Replace("-", "").Substring(6, 1).StartsWith("1") == true || birth.Replace("-", "").Substring(6, 1).StartsWith("3") == true) { sex = "남"; check = false; }
                else if (birth.Replace("-", "").Substring(6, 1).StartsWith("2") == true || birth.Replace("-", "").Substring(6, 1).StartsWith("4") == true) { sex = "여"; check = false; }
                else { Console.WriteLine("잘못입력하셨습니다."); check = true; }
            }

            if (birth.Replace("-", "").Substring(6, 1).StartsWith("1") == true || birth.Replace("-", "").Substring(6, 1).StartsWith("2") == true)
            { Console.WriteLine("19" + birth.Substring(0, 2) + "년" + birth.Replace("0", " ").Substring(2, 2) + "월" + birth.Substring(4, 2) + "일"); }
            else
            { Console.WriteLine("20" + birth.Substring(0, 2) + "년" + birth.Replace("0", " ").Substring(2, 2) + "월" + birth.Substring(4, 2) + "일"); }

            Console.WriteLine("성별은 " + sex + "자 입니다.");
            */

            string image = "D:\\2020_BBC\\image.jpg";
            string fileName = image.Substring(image.LastIndexOf("\\") + 1);
            string ext = image.Substring(image.LastIndexOf(".") + 1);
            int fileLength = image.Length - 1 - image.LastIndexOf("\\");
            Console.WriteLine("파일 명 -->> " + fileName);
            Console.WriteLine("확장자 -->> " + ext);
            Console.WriteLine("파일 이름 크기 -->> " + fileLength);

            if (ext.ToLower().Equals("jpg")) { Console.WriteLine("첨부 불가능 파일"); }

            //오늘의 15번째 주문번호

            string date = DateTime.Now.ToShortDateString();
            string date2 = date.Replace("-", "");
            date2 += "";
            Console.WriteLine(date2);

            int cnt = 15;
            string oderNum = cnt.ToString().PadLeft(5, '0');//Pad -->> 자릿수만큼 해당 문자로 채움
            date2 += oderNum;
            Console.WriteLine(date2);
        }
    }
}
