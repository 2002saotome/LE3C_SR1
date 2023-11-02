﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_01
{
    internal class FlyingRobot:Robot
    {
        //フィールド

        //メソッド------
        //コンストラクタ
        public FlyingRobot(string name)
        {
            this.name = name;
        }

        //爆弾を落とす
        public void DropBomb()
        {
            if(powerStatus) //if(powerStaus == true)と同じ意味
            {
                Console.WriteLine("{0}は、爆弾を落とした!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源offなので爆弾投下は使えません..", name);
            }
        }
    }
}
