namespace rms_testapp_cs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGetAccessToken = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdRefreshToken = new System.Windows.Forms.Button();
            this.cmdGetTerminalList = new System.Windows.Forms.Button();
            this.lvTerminals = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label6 = new System.Windows.Forms.Label();
            this.cmdSetTerminal = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.cmdCheckStatus = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblTransstatus = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.CmdMakeTransaction = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.txtoAuthUrl = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtaccess = new System.Windows.Forms.TextBox();
            this.txtRefresh = new System.Windows.Forms.TextBox();
            this.txtReturnUrl = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.txtTerminalId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGetAccessToken
            // 
            this.cmdGetAccessToken.Location = new System.Drawing.Point(6, 6);
            this.cmdGetAccessToken.Name = "cmdGetAccessToken";
            this.cmdGetAccessToken.Size = new System.Drawing.Size(154, 23);
            this.cmdGetAccessToken.TabIndex = 38;
            this.cmdGetAccessToken.Text = "Login";
            this.cmdGetAccessToken.UseVisualStyleBackColor = true;
            this.cmdGetAccessToken.Click += new System.EventHandler(this.cmdGetAccessToken_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBaseUrl);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtoAuthUrl);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtClientID);
            this.tabPage1.Controls.Add(this.txtaccess);
            this.tabPage1.Controls.Add(this.Label8);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.txtRefresh);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.txtReturnUrl);
            this.tabPage1.Controls.Add(this.txtSecret);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Credentials";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(7, 174);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 13);
            this.Label8.TabIndex = 46;
            this.Label8.Text = "SB RefreshToken*";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(7, 149);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(81, 13);
            this.Label7.TabIndex = 44;
            this.Label7.Text = "SB Acc Token*";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "SB ClientID*";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "SB Secret*";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 13);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "ISV Callback Url*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdRefreshToken);
            this.tabPage2.Controls.Add(this.cmdGetTerminalList);
            this.tabPage2.Controls.Add(this.lvTerminals);
            this.tabPage2.Controls.Add(this.Label6);
            this.tabPage2.Controls.Add(this.cmdSetTerminal);
            this.tabPage2.Controls.Add(this.cmdGetAccessToken);
            this.tabPage2.Controls.Add(this.txtTerminalId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merchant";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdRefreshToken
            // 
            this.cmdRefreshToken.Location = new System.Drawing.Point(625, 6);
            this.cmdRefreshToken.Name = "cmdRefreshToken";
            this.cmdRefreshToken.Size = new System.Drawing.Size(161, 23);
            this.cmdRefreshToken.TabIndex = 49;
            this.cmdRefreshToken.Text = "Refresh SB Access  Token";
            this.cmdRefreshToken.UseVisualStyleBackColor = true;
            this.cmdRefreshToken.Click += new System.EventHandler(this.cmdRefreshToken_Click);
            // 
            // cmdGetTerminalList
            // 
            this.cmdGetTerminalList.Location = new System.Drawing.Point(276, 22);
            this.cmdGetTerminalList.Name = "cmdGetTerminalList";
            this.cmdGetTerminalList.Size = new System.Drawing.Size(172, 23);
            this.cmdGetTerminalList.TabIndex = 43;
            this.cmdGetTerminalList.Text = "Get Merchants Terminals";
            this.cmdGetTerminalList.UseVisualStyleBackColor = true;
            this.cmdGetTerminalList.Click += new System.EventHandler(this.cmdGetTerminalList_Click);
            // 
            // lvTerminals
            // 
            this.lvTerminals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lvTerminals.HideSelection = false;
            this.lvTerminals.Location = new System.Drawing.Point(207, 51);
            this.lvTerminals.Name = "lvTerminals";
            this.lvTerminals.Size = new System.Drawing.Size(339, 248);
            this.lvTerminals.TabIndex = 42;
            this.lvTerminals.UseCompatibleStateImageBehavior = false;
            this.lvTerminals.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "TID";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Name";
            this.ColumnHeader2.Width = 124;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Status";
            this.ColumnHeader3.Width = 121;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 32);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 13);
            this.Label6.TabIndex = 41;
            this.Label6.Text = "RMD TID";
            // 
            // cmdSetTerminal
            // 
            this.cmdSetTerminal.Location = new System.Drawing.Point(8, 77);
            this.cmdSetTerminal.Name = "cmdSetTerminal";
            this.cmdSetTerminal.Size = new System.Drawing.Size(182, 23);
            this.cmdSetTerminal.TabIndex = 39;
            this.cmdSetTerminal.Text = "Link Terminal";
            this.cmdSetTerminal.UseVisualStyleBackColor = true;
            this.cmdSetTerminal.Click += new System.EventHandler(this.cmdSetTerminal_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtamount);
            this.tabPage3.Controls.Add(this.cmdCheckStatus);
            this.tabPage3.Controls.Add(this.Label4);
            this.tabPage3.Controls.Add(this.lblTransstatus);
            this.tabPage3.Controls.Add(this.Label5);
            this.tabPage3.Controls.Add(this.CmdMakeTransaction);
            this.tabPage3.Controls.Add(this.txtCurrency);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(75, 10);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 27;
            this.txtamount.Text = "1200";
            // 
            // cmdCheckStatus
            // 
            this.cmdCheckStatus.Location = new System.Drawing.Point(297, 63);
            this.cmdCheckStatus.Name = "cmdCheckStatus";
            this.cmdCheckStatus.Size = new System.Drawing.Size(188, 23);
            this.cmdCheckStatus.TabIndex = 31;
            this.cmdCheckStatus.Text = "check  Transaction status";
            this.cmdCheckStatus.UseVisualStyleBackColor = true;
            this.cmdCheckStatus.Click += new System.EventHandler(this.cmdCheckStatus_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Amount";
            // 
            // lblTransstatus
            // 
            this.lblTransstatus.AutoSize = true;
            this.lblTransstatus.Location = new System.Drawing.Point(95, 89);
            this.lblTransstatus.Name = "lblTransstatus";
            this.lblTransstatus.Size = new System.Drawing.Size(96, 13);
            this.lblTransstatus.TabIndex = 30;
            this.lblTransstatus.Text = "Transaction Status";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Currency";
            // 
            // CmdMakeTransaction
            // 
            this.CmdMakeTransaction.Location = new System.Drawing.Point(75, 63);
            this.CmdMakeTransaction.Name = "CmdMakeTransaction";
            this.CmdMakeTransaction.Size = new System.Drawing.Size(188, 23);
            this.CmdMakeTransaction.TabIndex = 29;
            this.CmdMakeTransaction.Text = "Make Transaction";
            this.CmdMakeTransaction.UseVisualStyleBackColor = true;
            this.CmdMakeTransaction.Click += new System.EventHandler(this.CmdMakeTransaction_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(75, 37);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(46, 20);
            this.txtCurrency.TabIndex = 28;
            this.txtCurrency.Text = "GBP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Api Base Url*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "oAuth Url*";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "apiUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBaseUrl.Location = new System.Drawing.Point(104, 107);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(489, 20);
            this.txtBaseUrl.TabIndex = 65;
            this.txtBaseUrl.Text = global::rms_testapp_cs.Properties.Settings.Default.apiUrl;
            // 
            // txtoAuthUrl
            // 
            this.txtoAuthUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "oAuthUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtoAuthUrl.Location = new System.Drawing.Point(104, 58);
            this.txtoAuthUrl.Name = "txtoAuthUrl";
            this.txtoAuthUrl.Size = new System.Drawing.Size(489, 20);
            this.txtoAuthUrl.TabIndex = 63;
            this.txtoAuthUrl.Text = global::rms_testapp_cs.Properties.Settings.Default.oAuthUrl;
            // 
            // txtClientID
            // 
            this.txtClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "clientid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClientID.Location = new System.Drawing.Point(104, 6);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(489, 20);
            this.txtClientID.TabIndex = 40;
            this.txtClientID.Text = global::rms_testapp_cs.Properties.Settings.Default.clientid;
            // 
            // txtaccess
            // 
            this.txtaccess.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "acc_token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtaccess.Location = new System.Drawing.Point(104, 143);
            this.txtaccess.Name = "txtaccess";
            this.txtaccess.Size = new System.Drawing.Size(489, 20);
            this.txtaccess.TabIndex = 45;
            this.txtaccess.Text = global::rms_testapp_cs.Properties.Settings.Default.acc_token;
            // 
            // txtRefresh
            // 
            this.txtRefresh.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "refresh_token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefresh.Location = new System.Drawing.Point(104, 169);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(489, 20);
            this.txtRefresh.TabIndex = 47;
            this.txtRefresh.Text = global::rms_testapp_cs.Properties.Settings.Default.refresh_token;
            // 
            // txtReturnUrl
            // 
            this.txtReturnUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "callbackurl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtReturnUrl.Location = new System.Drawing.Point(103, 83);
            this.txtReturnUrl.Name = "txtReturnUrl";
            this.txtReturnUrl.Size = new System.Drawing.Size(489, 20);
            this.txtReturnUrl.TabIndex = 43;
            this.txtReturnUrl.Text = global::rms_testapp_cs.Properties.Settings.Default.callbackurl;
            // 
            // txtSecret
            // 
            this.txtSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "secret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSecret.Location = new System.Drawing.Point(104, 32);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(489, 20);
            this.txtSecret.TabIndex = 41;
            this.txtSecret.Text = global::rms_testapp_cs.Properties.Settings.Default.secret;
            // 
            // txtTerminalId
            // 
            this.txtTerminalId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "rms_tid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTerminalId.Location = new System.Drawing.Point(8, 51);
            this.txtTerminalId.Name = "txtTerminalId";
            this.txtTerminalId.Size = new System.Drawing.Size(100, 20);
            this.txtTerminalId.TabIndex = 40;
            this.txtTerminalId.Text = global::rms_testapp_cs.Properties.Settings.Default.rms_tid;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RMS Test App ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdGetAccessToken;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.TextBox txtClientID;
        internal System.Windows.Forms.TextBox txtaccess;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRefresh;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtReturnUrl;
        internal System.Windows.Forms.TextBox txtSecret;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button cmdGetTerminalList;
        internal System.Windows.Forms.ListView lvTerminals;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button cmdSetTerminal;
        internal System.Windows.Forms.TextBox txtTerminalId;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.TextBox txtamount;
        internal System.Windows.Forms.Button cmdCheckStatus;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblTransstatus;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button CmdMakeTransaction;
        internal System.Windows.Forms.TextBox txtCurrency;
        internal System.Windows.Forms.Button cmdRefreshToken;
        internal System.Windows.Forms.TextBox txtBaseUrl;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtoAuthUrl;
        internal System.Windows.Forms.Label label10;
    }
}

