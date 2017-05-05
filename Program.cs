using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorL
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // ランダムな数字を2つ作成する
            // 生成したa1の値のみ表示させる
            Random rnd = new Random();
            int a1 = rnd.Next(10);
            int a2 = rnd.Next(10);

            Console.WriteLine(a1 + " : Hi or Low");
            //Console.WriteLine(a2);

            //ユーザから値を受け取る
            var usersAnswer = Console.ReadLine();

            // ユーザが入力した情報が正誤を判別する
            if (usersAnswer == "L" && a1 > a2)
            {
                Console.WriteLine("正解  :  " + a2);
            }
            else if (usersAnswer == "H" && a1 < a2)
            {
                Console.WriteLine("正解  :  " + a2);
            }
            else
            {
                Console.WriteLine("残念  :  " + a2);
            }      




            //コンソールが終了しないようにするため
            Console.Read();
        }
    }
}
