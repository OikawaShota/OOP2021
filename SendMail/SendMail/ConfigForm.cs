using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {

        public ConfigForm()
        {
            InitializeComponent();
        }
        private Settings st = Settings.getInstane();
        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text     = st.sHost();
            tbUserName.Text = st.sMailAddr();
            tbPort.Text     = st.sPort();
            tbPassword.Text = st.sPass();
            tbSender.Text   = st.sSender();
            cbSsl.Checked   = true;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            this.Close();
        }

        private void SettingRegist()
        {
            st.Host = tbHost.Text;
            st.MailAddr = tbUserName.Text;
            st.Pass = tbPassword.Text;
            st.Port = int.Parse(tbPort.Text);
            st.Ssl = cbSsl.Checked;
            st.Sender = tbSender.Text;

            var set = Settings.getInstane();
            set.Host = tbHost.Text;
            set.MailAddr = tbUserName.Text;
            set.Pass = tbPassword.Text;
            set.Port = int.Parse(tbPort.Text);
            set.Sender = tbSender.Text;
            set.Ssl = cbSsl.Checked;

            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (XmlWriter writer = XmlWriter.Create("Setting.xml", settings))
            {
                var serializer = new DataContractSerializer(set.GetType());
                serializer.WriteObject(writer, set);
            }
            MessageBox.Show("保存完了");
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = st.sHost();
            tbUserName.Text = st.sMailAddr();
            tbPort.Text = st.sPort();
            tbPassword.Text = st.sPass();
            tbSender.Text = st.sSender();
            cbSsl.Checked = true;
        }
    }
}
