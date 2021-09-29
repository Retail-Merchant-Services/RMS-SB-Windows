using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms_testapp_cs
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString().Contains("?code="))
            {
                // we have the code needed for the access token request
                this.Tag = webBrowser1.Url.ToString().Substring(webBrowser1.Url.ToString().IndexOf("?code=") + 6);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
