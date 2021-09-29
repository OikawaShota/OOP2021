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
        Settings s = new Settings();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text     = s.sHost();
            tbUserName.Text = s.sMailAddr();
            tbPort.Text     = s.sPort();
            tbPassword.Text = s.sPass();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            s.Host     = tbHost.Text;
            s.MailAddr = tbUserName.Text;
            s.Pass     = tbPassword.Text;
            s.Port     = int.Parse(tbPort.Text);
            s.Ssl      = cbSsl.Checked;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            s.Host = tbHost.Text;
            s.MailAddr = tbUserName.Text;
            s.Pass = tbPassword.Text;
            s.Port = int.Parse(tbPort.Text);
            s.Ssl = cbSsl.Checked;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
