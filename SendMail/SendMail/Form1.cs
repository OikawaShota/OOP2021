using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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
            btSend.Enabled = false;
            try
            {
                if (tbTo.Text.Trim()=="" || tbMessage.Text.Trim()=="")
                {
                    MessageBox.Show("アドレス又は本文が入力されていません");
                    btSend.Enabled = true;
                }
                else
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
                    smtpClient.SendAsync(mailMessage, userState);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("アドレス又は本文を入力してください");
                btSend.Enabled = true;
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
                btSend.Enabled = true;
            }
            else
            {
                NewMessege();
                MessageBox.Show("送信完了");
                btSend.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMessege();
        }

        private void NewMessege()
        {
            tbTo.Text = null;
            tbCc.Text = null;
            tbBcc.Text = null;
            tbMessage.Text = null;
        }
    }

}
