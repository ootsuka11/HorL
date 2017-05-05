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
            // 継続判定をするための変数
            // false になった場合終了
            bool chek = true;


            // chekがtrueの間周り続ける
            for (int i = 1; chek; i++)
            {
                // ランダムな数字を2つ作成する
                // 生成したa1の値のみ表示させる
                Random rnd = new Random();
                int a1 = rnd.Next(10);
                int a2 = rnd.Next(10);


                Console.WriteLine(i + " 問目");
                Console.WriteLine(a1 + " : Hi or Low");

                //ユーザから値を受け取る
                var usersAnswer = Console.ReadLine();



                // ユーザが入力した情報が正誤を判別する
                if (usersAnswer == "L" && a1 > a2)
                {
                    Console.WriteLine("正解  :  " + a2);
                    Console.WriteLine("--------------------------");
                    
                }
                else if (usersAnswer == "H" && a1 < a2)
                {
                    Console.WriteLine("正解  :  " + a2);
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    Console.WriteLine("残念  :  " + a2);
                    Console.WriteLine("終了しました、Enterを押してください");
                    chek = false;
                }



            }
            //コンソールが終了しないようにするため
            Console.Read();
        }
    }
}
