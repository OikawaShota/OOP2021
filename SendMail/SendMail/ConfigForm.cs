using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            st.Host     = tbHost.Text;
            st.MailAddr = tbUserName.Text;
            st.Pass     = tbPassword.Text;
            st.Port     = int.Parse(tbPort.Text);
            st.Ssl      = cbSsl.Checked;
            st.Sender   = tbSender.Text;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            st.Host     = tbHost.Text;
            st.MailAddr = tbUserName.Text;
            st.Pass     = tbPassword.Text;
            st.Port     = int.Parse(tbPort.Text);
            st.Ssl      = cbSsl.Checked;
            st.Sender   = tbSender.Text;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
