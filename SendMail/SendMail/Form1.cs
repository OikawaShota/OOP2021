using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //設定画面
        private ConfigForm cf = new ConfigForm();
        //設定情報
        private Settings st = Settings.getInstane();
        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                // メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(st.Sender);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(st.MailAddr, st.Pass);
                smtpClient.Host = st.Host;
                smtpClient.Port = st.Port;
                smtpClient.EnableSsl = st.Ssl;
                smtpClient.SendCompleted += SendComp;
                string userState = "SendMail";
                smtpClient.SendAsync (mailMessage,userState);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        private void SendComp(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
             XElement xset = XElement.Load(@"C:\Users\infosys\source\repos\OikawaShota\OOP2021\SendMail\SendMail\Setting.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("XMLファイルが見つかりませんでした。\n" +
                                "設定画面を起動します。");
                new ConfigForm().ShowDialog();
            }

        }
    }

}
