using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;
        public int    Port     { get; set; }    //ポート番号
        public string Host     { get; set; }    //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass     { get; set; }    //パスワード
        public bool   Ssl      { get; set; }    //SSL
        public string Sender   { get; set; }

        //コンストラクタ
        private Settings(){}

        //インスタンスの取得
        public static Settings getInstane()
        {
            if (instance == null)
            {
                instance = new Settings();
                try
                {
                    //逆シリアル化

                    using (var reader = XmlReader.Create("Setting.xml"))
                    {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var setter     = serializer.ReadObject(reader) as Settings;
                        instance.Host     = setter.Host;
                        instance.MailAddr = setter.MailAddr;
                        instance.Pass     = setter.Pass;
                        instance.Port     = setter.Port;
                        instance.Sender   = setter.Sender;
                        instance.Ssl      = setter.Ssl;
                    }

                }
                catch (Exception)
                {
                    //XMLファイルがなかった場合
                    MessageBox.Show("XMLファイルが見つかりませんでした。\n" +
                                    "設定画面を起動します。");
                    new ConfigForm().ShowDialog();
                }
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

        public bool bSsl()
        {
            return true;
        }
    }
}
