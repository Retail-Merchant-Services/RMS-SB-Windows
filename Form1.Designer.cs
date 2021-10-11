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
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtoAuthUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtaccess = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRefresh = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtReturnUrl = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
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
            this.txtTerminalId = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.cmdCheckStatus = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblTransstatus = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.CmdMakeTransaction = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cmdTest1 = new System.Windows.Forms.Button();
            this.cmdTest2 = new System.Windows.Forms.Button();
            this.cmdTest3 = new System.Windows.Forms.Button();
            this.cmdTest4 = new System.Windows.Forms.Button();
            this.cmdTest5 = new System.Windows.Forms.Button();
            this.cmdTest6 = new System.Windows.Forms.Button();
            this.cmdTest7 = new System.Windows.Forms.Button();
            this.cmdTest8 = new System.Windows.Forms.Button();
            this.cmdTest9 = new System.Windows.Forms.Button();
            this.cmdTest10 = new System.Windows.Forms.Button();
            this.cmdTest11 = new System.Windows.Forms.Button();
            this.cmdTest12 = new System.Windows.Forms.Button();
            this.cmdTest13 = new System.Windows.Forms.Button();
            this.cmdTest14 = new System.Windows.Forms.Button();
            this.cmdTest15 = new System.Windows.Forms.Button();
            this.cmdTest16 = new System.Windows.Forms.Button();
            this.cmdTest17 = new System.Windows.Forms.Button();
            this.cmdTest18 = new System.Windows.Forms.Button();
            this.cmdTest19 = new System.Windows.Forms.Button();
            this.cmdTest20 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 614);
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
            // txtBaseUrl
            // 
            this.txtBaseUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "apiUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBaseUrl.Location = new System.Drawing.Point(104, 107);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(489, 20);
            this.txtBaseUrl.TabIndex = 65;
            this.txtBaseUrl.Text = global::rms_testapp_cs.Properties.Settings.Default.apiUrl;
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
            // txtoAuthUrl
            // 
            this.txtoAuthUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "oAuthUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtoAuthUrl.Location = new System.Drawing.Point(104, 58);
            this.txtoAuthUrl.Name = "txtoAuthUrl";
            this.txtoAuthUrl.Size = new System.Drawing.Size(489, 20);
            this.txtoAuthUrl.TabIndex = 63;
            this.txtoAuthUrl.Text = global::rms_testapp_cs.Properties.Settings.Default.oAuthUrl;
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
            // txtRefresh
            // 
            this.txtRefresh.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "refresh_token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefresh.Location = new System.Drawing.Point(104, 169);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(489, 20);
            this.txtRefresh.TabIndex = 47;
            this.txtRefresh.Text = global::rms_testapp_cs.Properties.Settings.Default.refresh_token;
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
            this.tabPage2.Size = new System.Drawing.Size(792, 588);
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
            // txtTerminalId
            // 
            this.txtTerminalId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::rms_testapp_cs.Properties.Settings.Default, "rms_tid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTerminalId.Location = new System.Drawing.Point(8, 51);
            this.txtTerminalId.Name = "txtTerminalId";
            this.txtTerminalId.Size = new System.Drawing.Size(100, 20);
            this.txtTerminalId.TabIndex = 40;
            this.txtTerminalId.Text = global::rms_testapp_cs.Properties.Settings.Default.rms_tid;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
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
            this.tabPage3.Size = new System.Drawing.Size(792, 588);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Issue Refund";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel Transaction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 588);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test Cases";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cmdTest20, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest19, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest18, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest17, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest16, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest15, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest14, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest13, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest12, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest11, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.label29, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.label30, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.cmdTest1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label31, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOutput, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Merchant is authenticated into SmartBridge. ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Merchant can select the terminal (among multiple terminals) via Epos till. ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Merchant can initiate a sale via EPOS till. ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = " Merchant can initiate a refund via terminal. ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Merchant can cancel a transaction via terminal. ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Merchant can cancel a transaction via EPOS till. ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(302, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Merchant can list/filter the transactions by status via EPOS till. ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(288, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Merchant can list/filter the transactions by type via EPOS till";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(338, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Merchant can list/filter the transaction by transaction ID via EPOS till.  ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(213, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "EPOS till can retrieve details of transaction. ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 290);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(301, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "EPOS till can retrieve status of the ‘sale’ transaction outcome. ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 319);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(365, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "EPOS till can retrieve status of the ‘cancelled by user’ transaction outcome. ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 348);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(395, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "EPOS till can retrieve current stage of sale at any point in the transaction life" +
    "cycle. ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 377);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(198, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Merchant can print receipts via terminal. ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 406);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(273, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Merchant can process Chip and Pin (CNP) transactions. ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 435);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(217, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Merchant can process Swiped transactions. ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 464);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(237, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "Merchant can process Contactless transactions. ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 493);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(346, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "Merchant can view all transactions processed by a terminal in EPOS till. ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 522);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(273, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "Merchant can start a XBAL report for a specific terminal. ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 551);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(273, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "Merchant can start a ZBAL report for a specific terminal. ";
            // 
            // cmdTest1
            // 
            this.cmdTest1.Location = new System.Drawing.Point(404, 3);
            this.cmdTest1.Name = "cmdTest1";
            this.cmdTest1.Size = new System.Drawing.Size(75, 23);
            this.cmdTest1.TabIndex = 20;
            this.cmdTest1.Text = "Run Test";
            this.cmdTest1.UseVisualStyleBackColor = true;
            this.cmdTest1.Click += new System.EventHandler(this.cmdTest1_Click);
            // 
            // cmdTest2
            // 
            this.cmdTest2.Location = new System.Drawing.Point(404, 32);
            this.cmdTest2.Name = "cmdTest2";
            this.cmdTest2.Size = new System.Drawing.Size(75, 23);
            this.cmdTest2.TabIndex = 21;
            this.cmdTest2.Text = "Run Test";
            this.cmdTest2.UseVisualStyleBackColor = true;
            this.cmdTest2.Click += new System.EventHandler(this.cmdTest2_Click);
            // 
            // cmdTest3
            // 
            this.cmdTest3.Location = new System.Drawing.Point(404, 61);
            this.cmdTest3.Name = "cmdTest3";
            this.cmdTest3.Size = new System.Drawing.Size(75, 23);
            this.cmdTest3.TabIndex = 22;
            this.cmdTest3.Text = "Run Test";
            this.cmdTest3.UseVisualStyleBackColor = true;
            this.cmdTest3.Click += new System.EventHandler(this.cmdTest3_Click);
            // 
            // cmdTest4
            // 
            this.cmdTest4.Location = new System.Drawing.Point(404, 90);
            this.cmdTest4.Name = "cmdTest4";
            this.cmdTest4.Size = new System.Drawing.Size(75, 23);
            this.cmdTest4.TabIndex = 23;
            this.cmdTest4.Text = "Run Test";
            this.cmdTest4.UseVisualStyleBackColor = true;
            this.cmdTest4.Click += new System.EventHandler(this.cmdTest4_Click);
            // 
            // cmdTest5
            // 
            this.cmdTest5.Location = new System.Drawing.Point(404, 119);
            this.cmdTest5.Name = "cmdTest5";
            this.cmdTest5.Size = new System.Drawing.Size(75, 23);
            this.cmdTest5.TabIndex = 24;
            this.cmdTest5.Text = "Run Test";
            this.cmdTest5.UseVisualStyleBackColor = true;
            this.cmdTest5.Click += new System.EventHandler(this.cmdTest5_Click);
            // 
            // cmdTest6
            // 
            this.cmdTest6.Location = new System.Drawing.Point(404, 148);
            this.cmdTest6.Name = "cmdTest6";
            this.cmdTest6.Size = new System.Drawing.Size(75, 23);
            this.cmdTest6.TabIndex = 25;
            this.cmdTest6.Text = "Run Test";
            this.cmdTest6.UseVisualStyleBackColor = true;
            this.cmdTest6.Click += new System.EventHandler(this.cmdTest6_Click);
            // 
            // cmdTest7
            // 
            this.cmdTest7.Location = new System.Drawing.Point(404, 177);
            this.cmdTest7.Name = "cmdTest7";
            this.cmdTest7.Size = new System.Drawing.Size(75, 23);
            this.cmdTest7.TabIndex = 26;
            this.cmdTest7.Text = "Run Test";
            this.cmdTest7.UseVisualStyleBackColor = true;
            this.cmdTest7.Click += new System.EventHandler(this.cmdTest7_Click);
            // 
            // cmdTest8
            // 
            this.cmdTest8.Location = new System.Drawing.Point(404, 206);
            this.cmdTest8.Name = "cmdTest8";
            this.cmdTest8.Size = new System.Drawing.Size(75, 23);
            this.cmdTest8.TabIndex = 27;
            this.cmdTest8.Text = "Run Test";
            this.cmdTest8.UseVisualStyleBackColor = true;
            this.cmdTest8.Click += new System.EventHandler(this.cmdTest8_Click);
            // 
            // cmdTest9
            // 
            this.cmdTest9.Location = new System.Drawing.Point(404, 235);
            this.cmdTest9.Name = "cmdTest9";
            this.cmdTest9.Size = new System.Drawing.Size(75, 23);
            this.cmdTest9.TabIndex = 28;
            this.cmdTest9.Text = "Run Test";
            this.cmdTest9.UseVisualStyleBackColor = true;
            this.cmdTest9.Click += new System.EventHandler(this.cmdTest9_Click);
            // 
            // cmdTest10
            // 
            this.cmdTest10.Location = new System.Drawing.Point(404, 264);
            this.cmdTest10.Name = "cmdTest10";
            this.cmdTest10.Size = new System.Drawing.Size(75, 23);
            this.cmdTest10.TabIndex = 29;
            this.cmdTest10.Text = "Run Test";
            this.cmdTest10.UseVisualStyleBackColor = true;
            this.cmdTest10.Click += new System.EventHandler(this.cmdTest10_Click);
            // 
            // cmdTest11
            // 
            this.cmdTest11.Location = new System.Drawing.Point(404, 293);
            this.cmdTest11.Name = "cmdTest11";
            this.cmdTest11.Size = new System.Drawing.Size(75, 23);
            this.cmdTest11.TabIndex = 30;
            this.cmdTest11.Text = "Run Test";
            this.cmdTest11.UseVisualStyleBackColor = true;
            this.cmdTest11.Click += new System.EventHandler(this.cmdTest11_Click);
            // 
            // cmdTest12
            // 
            this.cmdTest12.Location = new System.Drawing.Point(404, 322);
            this.cmdTest12.Name = "cmdTest12";
            this.cmdTest12.Size = new System.Drawing.Size(75, 23);
            this.cmdTest12.TabIndex = 31;
            this.cmdTest12.Text = "Run Test";
            this.cmdTest12.UseVisualStyleBackColor = true;
            this.cmdTest12.Click += new System.EventHandler(this.cmdTest12_Click);
            // 
            // cmdTest13
            // 
            this.cmdTest13.Location = new System.Drawing.Point(404, 351);
            this.cmdTest13.Name = "cmdTest13";
            this.cmdTest13.Size = new System.Drawing.Size(75, 23);
            this.cmdTest13.TabIndex = 32;
            this.cmdTest13.Text = "Run Test";
            this.cmdTest13.UseVisualStyleBackColor = true;
            this.cmdTest13.Click += new System.EventHandler(this.cmdTest13_Click);
            // 
            // cmdTest14
            // 
            this.cmdTest14.Location = new System.Drawing.Point(404, 380);
            this.cmdTest14.Name = "cmdTest14";
            this.cmdTest14.Size = new System.Drawing.Size(75, 23);
            this.cmdTest14.TabIndex = 33;
            this.cmdTest14.Text = "Run Test";
            this.cmdTest14.UseVisualStyleBackColor = true;
            this.cmdTest14.Click += new System.EventHandler(this.cmdTest14_Click);
            // 
            // cmdTest15
            // 
            this.cmdTest15.Location = new System.Drawing.Point(404, 409);
            this.cmdTest15.Name = "cmdTest15";
            this.cmdTest15.Size = new System.Drawing.Size(75, 23);
            this.cmdTest15.TabIndex = 34;
            this.cmdTest15.Text = "Run Test";
            this.cmdTest15.UseVisualStyleBackColor = true;
            this.cmdTest15.Click += new System.EventHandler(this.cmdTest15_Click);
            // 
            // cmdTest16
            // 
            this.cmdTest16.Location = new System.Drawing.Point(404, 438);
            this.cmdTest16.Name = "cmdTest16";
            this.cmdTest16.Size = new System.Drawing.Size(75, 23);
            this.cmdTest16.TabIndex = 35;
            this.cmdTest16.Text = "Run Test";
            this.cmdTest16.UseVisualStyleBackColor = true;
            this.cmdTest16.Click += new System.EventHandler(this.cmdTest16_Click);
            // 
            // cmdTest17
            // 
            this.cmdTest17.Location = new System.Drawing.Point(404, 467);
            this.cmdTest17.Name = "cmdTest17";
            this.cmdTest17.Size = new System.Drawing.Size(75, 23);
            this.cmdTest17.TabIndex = 36;
            this.cmdTest17.Text = "Run Test";
            this.cmdTest17.UseVisualStyleBackColor = true;
            this.cmdTest17.Click += new System.EventHandler(this.cmdTest17_Click);
            // 
            // cmdTest18
            // 
            this.cmdTest18.Location = new System.Drawing.Point(404, 496);
            this.cmdTest18.Name = "cmdTest18";
            this.cmdTest18.Size = new System.Drawing.Size(75, 23);
            this.cmdTest18.TabIndex = 37;
            this.cmdTest18.Text = "Run Test";
            this.cmdTest18.UseVisualStyleBackColor = true;
            this.cmdTest18.Click += new System.EventHandler(this.cmdTest18_Click);
            // 
            // cmdTest19
            // 
            this.cmdTest19.Location = new System.Drawing.Point(404, 525);
            this.cmdTest19.Name = "cmdTest19";
            this.cmdTest19.Size = new System.Drawing.Size(75, 23);
            this.cmdTest19.TabIndex = 38;
            this.cmdTest19.Text = "Run Test";
            this.cmdTest19.UseVisualStyleBackColor = true;
            this.cmdTest19.Click += new System.EventHandler(this.cmdTest19_Click);
            // 
            // cmdTest20
            // 
            this.cmdTest20.Location = new System.Drawing.Point(404, 554);
            this.cmdTest20.Name = "cmdTest20";
            this.cmdTest20.Size = new System.Drawing.Size(75, 23);
            this.cmdTest20.TabIndex = 39;
            this.cmdTest20.Text = "Run Test";
            this.cmdTest20.UseVisualStyleBackColor = true;
            this.cmdTest20.Click += new System.EventHandler(this.cmdTest20_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(485, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 13);
            this.label31.TabIndex = 40;
            this.label31.Text = "Output";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(485, 29);
            this.lblOutput.Name = "lblOutput";
            this.tableLayoutPanel1.SetRowSpan(this.lblOutput, 19);
            this.lblOutput.Size = new System.Drawing.Size(169, 13);
            this.lblOutput.TabIndex = 41;
            this.lblOutput.Text = "Output from the test will show here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
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
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdTest20;
        private System.Windows.Forms.Button cmdTest19;
        private System.Windows.Forms.Button cmdTest18;
        private System.Windows.Forms.Button cmdTest17;
        private System.Windows.Forms.Button cmdTest16;
        private System.Windows.Forms.Button cmdTest15;
        private System.Windows.Forms.Button cmdTest14;
        private System.Windows.Forms.Button cmdTest13;
        private System.Windows.Forms.Button cmdTest12;
        private System.Windows.Forms.Button cmdTest11;
        private System.Windows.Forms.Button cmdTest10;
        private System.Windows.Forms.Button cmdTest9;
        private System.Windows.Forms.Button cmdTest8;
        private System.Windows.Forms.Button cmdTest7;
        private System.Windows.Forms.Button cmdTest6;
        private System.Windows.Forms.Button cmdTest5;
        private System.Windows.Forms.Button cmdTest4;
        private System.Windows.Forms.Button cmdTest3;
        private System.Windows.Forms.Button cmdTest2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button cmdTest1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblOutput;
    }
}

