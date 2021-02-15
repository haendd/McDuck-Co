namespace McDuck
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.homeTabControl = new System.Windows.Forms.TabControl();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.gpuStatusLabel = new System.Windows.Forms.Label();
            this.cpuStatusLabel = new System.Windows.Forms.Label();
            this.cpuPage = new System.Windows.Forms.TabPage();
            this.cpuCryptoSelectLabel = new System.Windows.Forms.Label();
            this.cpuStopButton = new System.Windows.Forms.Button();
            this.cpuLaunchButton = new System.Windows.Forms.Button();
            this.cpuCryptoSelector = new System.Windows.Forms.ComboBox();
            this.gpuPage = new System.Windows.Forms.TabPage();
            this.gpuStopButton = new System.Windows.Forms.Button();
            this.gpuCyrptoSelectLabel = new System.Windows.Forms.Label();
            this.gpuLaunchButton = new System.Windows.Forms.Button();
            this.gpuCryptoSelector = new System.Windows.Forms.ComboBox();
            this.walletSetupPage = new System.Windows.Forms.TabPage();
            this.cryptoTypePages = new System.Windows.Forms.TabControl();
            this.ethereumSetupPage = new System.Windows.Forms.TabPage();
            this.ethereumSaveButton = new System.Windows.Forms.Button();
            this.ethereumPoolAddressInput = new System.Windows.Forms.TextBox();
            this.ethereumPoolAddressLabel = new System.Windows.Forms.Label();
            this.ethereumWalletAddressInput = new System.Windows.Forms.TextBox();
            this.ethereumWalletAddressLabel = new System.Windows.Forms.Label();
            this.moneroSetupPage = new System.Windows.Forms.TabPage();
            this.moneroSaveButton = new System.Windows.Forms.Button();
            this.moneroPoolAddressInput = new System.Windows.Forms.TextBox();
            this.moneroPoolAddressLabel = new System.Windows.Forms.Label();
            this.moneroWalletAddressInput = new System.Windows.Forms.TextBox();
            this.moneroWalletAddressLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.homePage.SuspendLayout();
            this.homeTabControl.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            this.cpuPage.SuspendLayout();
            this.gpuPage.SuspendLayout();
            this.walletSetupPage.SuspendLayout();
            this.cryptoTypePages.SuspendLayout();
            this.ethereumSetupPage.SuspendLayout();
            this.moneroSetupPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homePage);
            this.mainTabControl.Controls.Add(this.walletSetupPage);
            this.mainTabControl.Location = new System.Drawing.Point(-1, -1);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(345, 360);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabControl.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.homeTabControl);
            this.homePage.Location = new System.Drawing.Point(4, 24);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(337, 332);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // homeTabControl
            // 
            this.homeTabControl.Controls.Add(this.dashboardPage);
            this.homeTabControl.Controls.Add(this.cpuPage);
            this.homeTabControl.Controls.Add(this.gpuPage);
            this.homeTabControl.Location = new System.Drawing.Point(0, 0);
            this.homeTabControl.Name = "homeTabControl";
            this.homeTabControl.SelectedIndex = 0;
            this.homeTabControl.Size = new System.Drawing.Size(341, 333);
            this.homeTabControl.TabIndex = 0;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Controls.Add(this.gpuStatusLabel);
            this.dashboardPage.Controls.Add(this.cpuStatusLabel);
            this.dashboardPage.Location = new System.Drawing.Point(4, 24);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardPage.Size = new System.Drawing.Size(333, 305);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // gpuStatusLabel
            // 
            this.gpuStatusLabel.AutoSize = true;
            this.gpuStatusLabel.Location = new System.Drawing.Point(6, 28);
            this.gpuStatusLabel.Name = "gpuStatusLabel";
            this.gpuStatusLabel.Size = new System.Drawing.Size(180, 15);
            this.gpuStatusLabel.TabIndex = 1;
            this.gpuStatusLabel.Text = "GPU Mining Status: Not Running";
            // 
            // cpuStatusLabel
            // 
            this.cpuStatusLabel.AutoSize = true;
            this.cpuStatusLabel.Location = new System.Drawing.Point(6, 4);
            this.cpuStatusLabel.Name = "cpuStatusLabel";
            this.cpuStatusLabel.Size = new System.Drawing.Size(180, 15);
            this.cpuStatusLabel.TabIndex = 0;
            this.cpuStatusLabel.Text = "CPU Mining Status: Not Running";
            // 
            // cpuPage
            // 
            this.cpuPage.Controls.Add(this.cpuCryptoSelectLabel);
            this.cpuPage.Controls.Add(this.cpuStopButton);
            this.cpuPage.Controls.Add(this.cpuLaunchButton);
            this.cpuPage.Controls.Add(this.cpuCryptoSelector);
            this.cpuPage.Location = new System.Drawing.Point(4, 24);
            this.cpuPage.Name = "cpuPage";
            this.cpuPage.Padding = new System.Windows.Forms.Padding(3);
            this.cpuPage.Size = new System.Drawing.Size(333, 305);
            this.cpuPage.TabIndex = 1;
            this.cpuPage.Text = "CPU Miner";
            this.cpuPage.UseVisualStyleBackColor = true;
            // 
            // cpuCryptoSelectLabel
            // 
            this.cpuCryptoSelectLabel.AutoSize = true;
            this.cpuCryptoSelectLabel.Location = new System.Drawing.Point(5, 9);
            this.cpuCryptoSelectLabel.Name = "cpuCryptoSelectLabel";
            this.cpuCryptoSelectLabel.Size = new System.Drawing.Size(104, 15);
            this.cpuCryptoSelectLabel.TabIndex = 3;
            this.cpuCryptoSelectLabel.Text = "Select Crypto Type";
            // 
            // cpuStopButton
            // 
            this.cpuStopButton.Location = new System.Drawing.Point(250, 279);
            this.cpuStopButton.Name = "cpuStopButton";
            this.cpuStopButton.Size = new System.Drawing.Size(75, 23);
            this.cpuStopButton.TabIndex = 1;
            this.cpuStopButton.Text = "Stop";
            this.cpuStopButton.UseVisualStyleBackColor = true;
            this.cpuStopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // cpuLaunchButton
            // 
            this.cpuLaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuLaunchButton.Location = new System.Drawing.Point(5, 279);
            this.cpuLaunchButton.Name = "cpuLaunchButton";
            this.cpuLaunchButton.Size = new System.Drawing.Size(75, 23);
            this.cpuLaunchButton.TabIndex = 0;
            this.cpuLaunchButton.Text = "Launch";
            this.cpuLaunchButton.UseVisualStyleBackColor = true;
            this.cpuLaunchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // cpuCryptoSelector
            // 
            this.cpuCryptoSelector.FormattingEnabled = true;
            this.cpuCryptoSelector.Items.AddRange(new object[] {
            "Monero"});
            this.cpuCryptoSelector.Location = new System.Drawing.Point(5, 27);
            this.cpuCryptoSelector.Name = "cpuCryptoSelector";
            this.cpuCryptoSelector.Size = new System.Drawing.Size(320, 23);
            this.cpuCryptoSelector.TabIndex = 2;
            this.cpuCryptoSelector.Text = "<Select Type of Crypto>";
            // 
            // gpuPage
            // 
            this.gpuPage.Controls.Add(this.gpuStopButton);
            this.gpuPage.Controls.Add(this.gpuCyrptoSelectLabel);
            this.gpuPage.Controls.Add(this.gpuLaunchButton);
            this.gpuPage.Controls.Add(this.gpuCryptoSelector);
            this.gpuPage.Location = new System.Drawing.Point(4, 24);
            this.gpuPage.Name = "gpuPage";
            this.gpuPage.Size = new System.Drawing.Size(333, 305);
            this.gpuPage.TabIndex = 2;
            this.gpuPage.Text = "GPU Miner";
            this.gpuPage.UseVisualStyleBackColor = true;
            // 
            // gpuStopButton
            // 
            this.gpuStopButton.Location = new System.Drawing.Point(250, 279);
            this.gpuStopButton.Name = "gpuStopButton";
            this.gpuStopButton.Size = new System.Drawing.Size(75, 23);
            this.gpuStopButton.TabIndex = 1;
            this.gpuStopButton.Text = "Stop";
            this.gpuStopButton.UseVisualStyleBackColor = true;
            this.gpuStopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // gpuCyrptoSelectLabel
            // 
            this.gpuCyrptoSelectLabel.AutoSize = true;
            this.gpuCyrptoSelectLabel.Location = new System.Drawing.Point(5, 9);
            this.gpuCyrptoSelectLabel.Name = "gpuCyrptoSelectLabel";
            this.gpuCyrptoSelectLabel.Size = new System.Drawing.Size(104, 15);
            this.gpuCyrptoSelectLabel.TabIndex = 3;
            this.gpuCyrptoSelectLabel.Text = "Select Crypto Type";
            // 
            // gpuLaunchButton
            // 
            this.gpuLaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpuLaunchButton.Location = new System.Drawing.Point(5, 279);
            this.gpuLaunchButton.Name = "gpuLaunchButton";
            this.gpuLaunchButton.Size = new System.Drawing.Size(75, 23);
            this.gpuLaunchButton.TabIndex = 0;
            this.gpuLaunchButton.Text = "Launch";
            this.gpuLaunchButton.UseVisualStyleBackColor = true;
            this.gpuLaunchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // gpuCryptoSelector
            // 
            this.gpuCryptoSelector.FormattingEnabled = true;
            this.gpuCryptoSelector.Items.AddRange(new object[] {
            "Ethereum"});
            this.gpuCryptoSelector.Location = new System.Drawing.Point(5, 27);
            this.gpuCryptoSelector.Name = "gpuCryptoSelector";
            this.gpuCryptoSelector.Size = new System.Drawing.Size(320, 23);
            this.gpuCryptoSelector.TabIndex = 2;
            this.gpuCryptoSelector.Text = "<Select Type of Crypto>";
            // 
            // walletSetupPage
            // 
            this.walletSetupPage.Controls.Add(this.cryptoTypePages);
            this.walletSetupPage.Location = new System.Drawing.Point(4, 24);
            this.walletSetupPage.Name = "walletSetupPage";
            this.walletSetupPage.Padding = new System.Windows.Forms.Padding(3);
            this.walletSetupPage.Size = new System.Drawing.Size(337, 332);
            this.walletSetupPage.TabIndex = 1;
            this.walletSetupPage.Text = "Wallet Setup";
            this.walletSetupPage.UseVisualStyleBackColor = true;
            // 
            // cryptoTypePages
            // 
            this.cryptoTypePages.Controls.Add(this.ethereumSetupPage);
            this.cryptoTypePages.Controls.Add(this.moneroSetupPage);
            this.cryptoTypePages.Location = new System.Drawing.Point(-1, -1);
            this.cryptoTypePages.Name = "cryptoTypePages";
            this.cryptoTypePages.SelectedIndex = 0;
            this.cryptoTypePages.Size = new System.Drawing.Size(341, 333);
            this.cryptoTypePages.TabIndex = 0;
            // 
            // ethereumSetupPage
            // 
            this.ethereumSetupPage.Controls.Add(this.ethereumSaveButton);
            this.ethereumSetupPage.Controls.Add(this.ethereumPoolAddressInput);
            this.ethereumSetupPage.Controls.Add(this.ethereumPoolAddressLabel);
            this.ethereumSetupPage.Controls.Add(this.ethereumWalletAddressInput);
            this.ethereumSetupPage.Controls.Add(this.ethereumWalletAddressLabel);
            this.ethereumSetupPage.Location = new System.Drawing.Point(4, 24);
            this.ethereumSetupPage.Name = "ethereumSetupPage";
            this.ethereumSetupPage.Padding = new System.Windows.Forms.Padding(3);
            this.ethereumSetupPage.Size = new System.Drawing.Size(333, 305);
            this.ethereumSetupPage.TabIndex = 0;
            this.ethereumSetupPage.Text = "Ethereum";
            this.ethereumSetupPage.UseVisualStyleBackColor = true;
            // 
            // ethereumSaveButton
            // 
            this.ethereumSaveButton.Location = new System.Drawing.Point(250, 274);
            this.ethereumSaveButton.Name = "ethereumSaveButton";
            this.ethereumSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ethereumSaveButton.TabIndex = 4;
            this.ethereumSaveButton.Text = "Save";
            this.ethereumSaveButton.UseVisualStyleBackColor = true;
            this.ethereumSaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ethereumPoolAddressInput
            // 
            this.ethereumPoolAddressInput.Location = new System.Drawing.Point(6, 72);
            this.ethereumPoolAddressInput.Name = "ethereumPoolAddressInput";
            this.ethereumPoolAddressInput.Size = new System.Drawing.Size(319, 23);
            this.ethereumPoolAddressInput.TabIndex = 3;
            this.ethereumPoolAddressInput.Text = "eth-us-east1.nanopool.org:9999";
            // 
            // ethereumPoolAddressLabel
            // 
            this.ethereumPoolAddressLabel.AutoSize = true;
            this.ethereumPoolAddressLabel.Location = new System.Drawing.Point(7, 54);
            this.ethereumPoolAddressLabel.Name = "ethereumPoolAddressLabel";
            this.ethereumPoolAddressLabel.Size = new System.Drawing.Size(76, 15);
            this.ethereumPoolAddressLabel.TabIndex = 2;
            this.ethereumPoolAddressLabel.Text = "Pool Address";
            // 
            // ethereumWalletAddressInput
            // 
            this.ethereumWalletAddressInput.Location = new System.Drawing.Point(7, 23);
            this.ethereumWalletAddressInput.Name = "ethereumWalletAddressInput";
            this.ethereumWalletAddressInput.Size = new System.Drawing.Size(319, 23);
            this.ethereumWalletAddressInput.TabIndex = 1;
            this.ethereumWalletAddressInput.Text = "0x2a02A9C03D5B2E8CCF0af59EC4d4B3CEb884e557";
            // 
            // ethereumWalletAddressLabel
            // 
            this.ethereumWalletAddressLabel.AutoSize = true;
            this.ethereumWalletAddressLabel.Location = new System.Drawing.Point(7, 4);
            this.ethereumWalletAddressLabel.Name = "ethereumWalletAddressLabel";
            this.ethereumWalletAddressLabel.Size = new System.Drawing.Size(85, 15);
            this.ethereumWalletAddressLabel.TabIndex = 0;
            this.ethereumWalletAddressLabel.Text = "Wallet Address";
            // 
            // moneroSetupPage
            // 
            this.moneroSetupPage.Controls.Add(this.moneroSaveButton);
            this.moneroSetupPage.Controls.Add(this.moneroPoolAddressInput);
            this.moneroSetupPage.Controls.Add(this.moneroPoolAddressLabel);
            this.moneroSetupPage.Controls.Add(this.moneroWalletAddressInput);
            this.moneroSetupPage.Controls.Add(this.moneroWalletAddressLabel);
            this.moneroSetupPage.Location = new System.Drawing.Point(4, 24);
            this.moneroSetupPage.Name = "moneroSetupPage";
            this.moneroSetupPage.Padding = new System.Windows.Forms.Padding(3);
            this.moneroSetupPage.Size = new System.Drawing.Size(333, 305);
            this.moneroSetupPage.TabIndex = 1;
            this.moneroSetupPage.Text = "Monero";
            this.moneroSetupPage.UseVisualStyleBackColor = true;
            // 
            // moneroSaveButton
            // 
            this.moneroSaveButton.Location = new System.Drawing.Point(250, 274);
            this.moneroSaveButton.Name = "moneroSaveButton";
            this.moneroSaveButton.Size = new System.Drawing.Size(75, 23);
            this.moneroSaveButton.TabIndex = 4;
            this.moneroSaveButton.Text = "Save";
            this.moneroSaveButton.UseVisualStyleBackColor = true;
            this.moneroSaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moneroPoolAddressInput
            // 
            this.moneroPoolAddressInput.Location = new System.Drawing.Point(7, 72);
            this.moneroPoolAddressInput.Name = "moneroPoolAddressInput";
            this.moneroPoolAddressInput.Size = new System.Drawing.Size(319, 23);
            this.moneroPoolAddressInput.TabIndex = 3;
            this.moneroPoolAddressInput.Text = "xmr-us-east1.nanopool.org:9999";
            // 
            // moneroPoolAddressLabel
            // 
            this.moneroPoolAddressLabel.AutoSize = true;
            this.moneroPoolAddressLabel.Location = new System.Drawing.Point(7, 54);
            this.moneroPoolAddressLabel.Name = "moneroPoolAddressLabel";
            this.moneroPoolAddressLabel.Size = new System.Drawing.Size(76, 15);
            this.moneroPoolAddressLabel.TabIndex = 2;
            this.moneroPoolAddressLabel.Text = "Pool Address";
            // 
            // moneroWalletAddressInput
            // 
            this.moneroWalletAddressInput.Location = new System.Drawing.Point(7, 23);
            this.moneroWalletAddressInput.Name = "moneroWalletAddressInput";
            this.moneroWalletAddressInput.Size = new System.Drawing.Size(319, 23);
            this.moneroWalletAddressInput.TabIndex = 1;
            this.moneroWalletAddressInput.Text = "41sMR63mDEoAkGkxAC73EcEJBpEgXtCbi1a7RkvWZRiyGz5RLyM2pHvRdjZK1RxbH5UaVVT1nqK8nKcdd" +
    "UVJJCBsHkjXg4S";
            // 
            // moneroWalletAddressLabel
            // 
            this.moneroWalletAddressLabel.AutoSize = true;
            this.moneroWalletAddressLabel.Location = new System.Drawing.Point(7, 4);
            this.moneroWalletAddressLabel.Name = "moneroWalletAddressLabel";
            this.moneroWalletAddressLabel.Size = new System.Drawing.Size(85, 15);
            this.moneroWalletAddressLabel.TabIndex = 0;
            this.moneroWalletAddressLabel.Text = "Wallet Address";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 357);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "McDuck Crypto";
            this.Load += new System.EventHandler(this.Form_Load);
            this.mainTabControl.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.homeTabControl.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            this.cpuPage.ResumeLayout(false);
            this.cpuPage.PerformLayout();
            this.gpuPage.ResumeLayout(false);
            this.gpuPage.PerformLayout();
            this.walletSetupPage.ResumeLayout(false);
            this.cryptoTypePages.ResumeLayout(false);
            this.ethereumSetupPage.ResumeLayout(false);
            this.ethereumSetupPage.PerformLayout();
            this.moneroSetupPage.ResumeLayout(false);
            this.moneroSetupPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage walletSetupPage;
        private System.Windows.Forms.Button cpuStopButton;
        private System.Windows.Forms.Button cpuLaunchButton;
        private System.Windows.Forms.TabControl cryptoTypePages;
        private System.Windows.Forms.TabPage ethereumSetupPage;
        private System.Windows.Forms.Label ethereumWalletAddressLabel;
        private System.Windows.Forms.TabPage moneroSetupPage;
        private System.Windows.Forms.TextBox ethereumWalletAddressInput;
        private System.Windows.Forms.Label cpuCryptoSelectLabel;
        private System.Windows.Forms.ComboBox cpuCryptoSelector;
        private System.Windows.Forms.TextBox ethereumPoolAddressInput;
        private System.Windows.Forms.Label ethereumPoolAddressLabel;
        private System.Windows.Forms.TextBox moneroPoolAddressInput;
        private System.Windows.Forms.Label moneroPoolAddressLabel;
        private System.Windows.Forms.TextBox moneroWalletAddressInput;
        private System.Windows.Forms.Label moneroWalletAddressLabel;
        private System.Windows.Forms.Button ethereumSaveButton;
        private System.Windows.Forms.Button moneroSaveButton;
        private System.Windows.Forms.TabControl homeTabControl;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage cpuPage;
        private System.Windows.Forms.TabPage gpuPage;
        private System.Windows.Forms.Label gpuCyrptoSelectLabel;
        private System.Windows.Forms.ComboBox gpuCryptoSelector;
        private System.Windows.Forms.Button gpuLaunchButton;
        private System.Windows.Forms.Label gpuStatusLabel;
        private System.Windows.Forms.Label cpuStatusLabel;
        private System.Windows.Forms.Button gpuStopButton;
    }
}

