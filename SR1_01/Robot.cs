using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SR1_01
{
    internal class Robot
    {
        //フィールド ------------------
        protected string name = ""; //初期値は""
        protected bool powerStatus = false; //初期値はfalse

        //メソッド ------------------
        //電源をOnにする

        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した!!", name);
        }

        //電源をOFFにする
        public void PowerOff()
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した..", name);
        }

        //名前の取得する
        public string Getname()
        {
            return name;
        }

        //電源Onの状態を取得する
        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}
