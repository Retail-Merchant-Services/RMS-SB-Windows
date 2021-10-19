using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace rms_testapp_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void IEbrowserFix()
        {
            try
            {
                Microsoft.Win32.RegistryKey regDM;
                bool is64 = Environment.Is64BitOperatingSystem;
                string KeyPath = "";
                if (is64)
                {
                    KeyPath = @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
                }
                else
                {
                    KeyPath = @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
                }

                regDM = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, false);
                if (regDM is null)
                {
                    regDM = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(KeyPath);
                }

                Microsoft.Win32.RegistryKey Sleutel;
                if (regDM is object)
                {
                    string location = Environment.GetCommandLineArgs()[0];
                    string appName = Path.GetFileName(location);
                    Sleutel = (Microsoft.Win32.RegistryKey)regDM.GetValue(appName);
                    if (Sleutel is null)
                    {
                        // Sleutel onbekend
                        regDM = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, true);
                        Sleutel = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(KeyPath, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

                        // What OS are we using
                        var OsVersion = Environment.OSVersion.Version;
                        if (OsVersion.Major == 6 & OsVersion.Minor == 1)
                        {
                            // WIN 7
                             Sleutel.SetValue(appName, 9000, Microsoft.Win32.RegistryValueKind.DWord);
                        }
                        else if (OsVersion.Major == 6 & OsVersion.Minor == 2)
                        {
                            // WIN 8 and above
                            Sleutel.SetValue(appName, 10000, Microsoft.Win32.RegistryValueKind.DWord);
                        }
                        else if (OsVersion.Major == 5 & OsVersion.Minor == 1)
                        {
                            // WIN xp
                            Sleutel.SetValue(appName, 8000, Microsoft.Win32.RegistryValueKind.DWord);
                        }

                        Sleutel.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\nYou need to run as Administrator to alter the registry");
            }
        }
        private void cmdGetAccessToken_Click(object sender, EventArgs e)
        {
            //If you receive script errors on login then call this 
           // IEbrowserFix();
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            Properties.Settings.Default.Save();
            string url = rms.getoAuthUrl();
            var frm = new frmlogin();
            frm.webBrowser1.Navigate(url);
            frm.ShowDialog();
            string code = (string)frm.Tag;
            frm.Close();
            frm = default;
            if (string.IsNullOrEmpty(code))
                return;
            try
            {
                JObject resp = (JObject)rms.GetToken(code);
                txtaccess.Text = (string)resp["access_token"];
                txtRefresh.Text = (string)resp["refresh_token"];
                MessageBox.Show("Login Successfull");
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSetTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                var rms = new SmartBridge.Api();
                rms.setoAuthUrl(txtoAuthUrl.Text);
                rms.setBaseUrl(txtBaseUrl.Text);
                rms.setKey(txtClientID.Text);
                rms.setSecret(txtSecret.Text);
                rms.setToken(txtaccess.Text);
                rms.setRefreshToken(txtRefresh.Text);
                rms.setCallBackUrl(txtReturnUrl.Text);
                rms.SetActiveTerminal(txtTerminalId.Text);
                MessageBox.Show("The terminal has been set");
 
                Properties.Settings.Default.Save();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGetTerminalList_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            object terminals;
            lvTerminals.Items.Clear();
            try
            {
                terminals = rms.GetTerminalList();
                foreach (JObject terminal in (IEnumerable)terminals)
                {
                    var li = new ListViewItem();
                    li.Text = terminal["terminalId"].ToString();
                    li.SubItems.Add((terminal["terminalName"] is null)? terminal["terminalId"].ToString():terminal["terminalName"].ToString());
                    li.SubItems.Add(terminal["terminalStatus"].ToString());
                    lvTerminals.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRefreshToken_Click(object sender, EventArgs e)
        {
            try
            {
                var rms = new SmartBridge.Api();
                rms.setoAuthUrl(txtoAuthUrl.Text);
                rms.setBaseUrl(txtBaseUrl.Text);
                rms.setKey(txtClientID.Text);
                rms.setSecret(txtSecret.Text);
                rms.setRefreshToken(txtRefresh.Text);
                rms.setCallBackUrl(txtReturnUrl.Text);
                JObject j = (JObject)rms.refreshtoken();
                if (j["access_token"] is object)
                {
                    txtaccess.Text = j["access_token"].ToString();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Access Token has been updated");
                    return;
                }

                MessageBox.Show(j.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdMakeTransaction_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp =(JObject) rms.CreateTransaction(int.Parse(txtamount.Text), txtCurrency.Text, "SALE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("Transaction successfull \r\nCheck Status for approval");
        }

        private void cmdCheckStatus_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            object resp;
            try
            {
                resp = rms.CheckStatus((string)cmdCheckStatus.Tag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            lblTransstatus.Text = (resp is null)?"":resp.ToString();

        }

        private void cmdCancelTransaction_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            object resp;
            try
            {
                resp = rms.CancelTransaction((string)cmdCheckStatus.Tag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            lblTransstatus.Text = (resp is null) ? "" : resp.ToString();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(int.Parse(txtamount.Text), txtCurrency.Text, "REFUND");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("Refund Transaction successfull \r\nCheck Status for approval");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            object resp;
            try
            {
                resp = rms.CancelTransaction((string)cmdCheckStatus.Tag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            lblTransstatus.Text = (resp is null) ? "" : resp.ToString();
        }

        private void cmdTest1_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            Properties.Settings.Default.Save();
            string url = rms.getoAuthUrl();
            var frm = new frmlogin();
            frm.webBrowser1.Navigate(url);
            frm.ShowDialog();
            string code = (string)frm.Tag;
            frm.Close();
            frm = default;
            if (string.IsNullOrEmpty(code))
                return;
            try
            {
                JObject resp = (JObject)rms.GetToken(code);
                lblOutput.Text = resp.ToString();
                txtaccess.Text = (string)resp["access_token"];
                txtRefresh.Text = (string)resp["refresh_token"];
                MessageBox.Show("Login Successfull");
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdTest2_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            object terminals;
            lvTerminals.Items.Clear();
            try
            {
                terminals = rms.GetTerminalList();
                lblOutput.Text = terminals.ToString();
                foreach (JObject terminal in (IEnumerable)terminals)
                {
                    var li = new ListViewItem();
                    li.Text = terminal["terminalId"].ToString();
                    li.SubItems.Add((terminal["terminalName"] is null) ? terminal["terminalId"].ToString() : terminal["terminalName"].ToString());
                    li.SubItems.Add(terminal["terminalStatus"].ToString());
                    lvTerminals.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdTest3_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("Transaction " + transactionid + " successfull \r\nCheck Status for approval");
        }

        private void cmdTest4_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "REFUND");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("REFUND Transaction " + transactionid + " successfull \r\nCheck Status for approval");
        }

        private void cmdTest5_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("Transaction " + transactionid + " successfull \r\nPlease press cancel on the terminal");
        }

        private void cmdTest6_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created ");
            try
            {
                resp= (JObject)rms.CancelTransaction(transactionid);
                lblOutput.Text += resp.ToString();

            }
            catch (Exception ex) { }
          
            cmdCheckStatus.Tag = transactionid;
            MessageBox.Show("Transaction " + transactionid + "  canceled");
        }

        private void cmdTest7_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.GetTransactionsByStatus("SUCCESSFUL");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdTest8_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.GetTransactionsByType("SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdTest9_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created ");
            try
            {
                resp = (JObject)rms.GetTransactionById(transactionid);
                lblOutput.Text += resp.ToString();

            }
            catch (Exception ex) { }

            cmdCheckStatus.Tag = transactionid;
          
        }

        private void cmdTest10_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created , Retrieving Details...");
            try
            {
                resp = (JObject)rms.GetTransactionById(transactionid);
                lblOutput.Text += resp.ToString();

            }
            catch (Exception ex) { }

            cmdCheckStatus.Tag = transactionid;

        }

        private void cmdTest11_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created.\n Complete the transaction on the terminal. \nThen press ok on this Dialog");
            try
            {
                resp = (JObject)rms.GetTransactionById(transactionid);
                lblOutput.Text += resp.ToString();

            }
            catch (Exception ex) { }

            cmdCheckStatus.Tag = transactionid;
        }

        private void cmdTest12_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created.\n Cancel the transaction on the terminal. \nThen press ok on this Dialog");
            try
            {
                resp = (JObject)rms.GetTransactionById(transactionid);
                lblOutput.Text += resp.ToString();

            }
            catch (Exception ex) { }

            cmdCheckStatus.Tag = transactionid;
        }

        private void cmdTest13_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string transactionid = resp["transactionid"].ToString();
            MessageBox.Show("Transaction " + transactionid + " created.\nPress ok on this Dialog when you want the Transaction Stage");
            try
            {
                resp = (JObject)rms.GetTransactionById(transactionid);
                lblOutput.Text += "\nTransaction Stage:"+ resp["transactionStage"].ToString()+"\n";

            }
            catch (Exception ex) { }

            cmdCheckStatus.Tag = transactionid;
        }

        private void cmdTest14_Click(object sender, EventArgs e)
        {

        }

        private void cmdTest19_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            rms.RequestReportByType("XBAL");
        }

        private void cmdTest20_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            rms.RequestReportByType("ZBAL");
        }

        private void cmdTest15_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdTest16_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdTest17_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.CreateTransaction(2400, "GBP", "SALE");
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdTest18_Click(object sender, EventArgs e)
        {
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setToken(txtaccess.Text);
            rms.setRefreshToken(txtRefresh.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            rms.SetActiveTerminal(txtTerminalId.Text);
            JObject resp;
            try
            {
                resp = (JObject)rms.GetTransactions();
                lblOutput.Text = resp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            //If you receive script errors on login then call this 
            // IEbrowserFix();
            var rms = new SmartBridge.Api();
            rms.setoAuthUrl(txtoAuthUrl.Text);
            rms.setBaseUrl(txtBaseUrl.Text);
            rms.setKey(txtClientID.Text);
            rms.setSecret(txtSecret.Text);
            rms.setCallBackUrl(txtReturnUrl.Text);
            Properties.Settings.Default.Save();
            string url = rms.getLogoutUrl();
            var frm = new frmlogin();
            frm.webBrowser1.Navigate(url);
            frm.ShowDialog();
            string code = (string)frm.Tag;
            frm.Close();
            frm = default;
            if (string.IsNullOrEmpty(code))
                return;
            try
            {
                JObject resp = (JObject)rms.GetToken(code);
                txtaccess.Text = (string)resp["access_token"];
                txtRefresh.Text = (string)resp["refresh_token"];
                MessageBox.Show("Login Successfull");
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
