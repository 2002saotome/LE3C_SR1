using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_01
{
    internal class Dog
    {
        //状態や属性「データ」・・・フィールド
        private bool hungryState;

        //振る舞い「操作」 ・・・メソッド

        //コンストラクタ(クラス名 Dog と同じ名前のメソッド Dog)
        public Dog()
        {
            hungryState = true;
        }

        //食べる→満腹になる

        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false; //おなかはすいてない
        }

        //走る！！→腹ペコ状態にする
        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState = true;　　//おなかがすいた
        }

        public bool IsHungry()
        {
            return hungryState;
        }
    }
}
