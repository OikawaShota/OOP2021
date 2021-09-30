using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;

        public int Port { get; set; }       //ポート番号
        public string Host { get; set; }    //ホスト名
        public string MailAddr { get; set; }//メールアドレス
        public string Pass { get; set; }    //パスワード
        public bool Ssl { get; set; }       //SSL
        public string Sender { get; set; }

        //コンストラクタ
        private Settings(){}

        //インスタンスの取得
        public static Settings getInstane()
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";
        }

        public string sPort()
        {
            return 587.ToString();
        }

        public string sMailAddr()
        {
            return @"OjsInfosys01@gmail.com";
        }

        public string sPass()
        {
            return "Infosys2021";
        }

        public string sSender()
        {
            return @"OjsInfosys01@gmail.com";
        }
    }
}
