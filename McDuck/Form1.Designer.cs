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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.launcherPage = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.launcherCryptoSelectLabel = new System.Windows.Forms.Label();
            this.launcherCryptoSelector = new System.Windows.Forms.ComboBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.walletSetupPage = new System.Windows.Forms.TabPage();
            this.cryptoTypePages = new System.Windows.Forms.TabControl();
            this.ethereumSetupPage = new System.Windows.Forms.TabPage();
            this.ethereumPoolAddressInput = new System.Windows.Forms.TextBox();
            this.ethereumPoolAddressLabel = new System.Windows.Forms.Label();
            this.ethereumWalletAddressInput = new System.Windows.Forms.TextBox();
            this.ethereumWalletAddressLabel = new System.Windows.Forms.Label();
            this.moneroSetupPage = new System.Windows.Forms.TabPage();
            this.moneroPoolAddressInput = new System.Windows.Forms.TextBox();
            this.moneroPoolAddressLabel = new System.Windows.Forms.Label();
            this.moneroWalletAddressInput = new System.Windows.Forms.TextBox();
            this.moneroWalletAddressLabel = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.launcherPage.SuspendLayout();
            this.walletSetupPage.SuspendLayout();
            this.cryptoTypePages.SuspendLayout();
            this.ethereumSetupPage.SuspendLayout();
            this.moneroSetupPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.launcherPage);
            this.tabControl.Controls.Add(this.walletSetupPage);
            this.tabControl.Location = new System.Drawing.Point(-2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(345, 360);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // launcherPage
            // 
            this.launcherPage.Controls.Add(this.consoleTextBox);
            this.launcherPage.Controls.Add(this.saveButton);
            this.launcherPage.Controls.Add(this.launcherCryptoSelectLabel);
            this.launcherPage.Controls.Add(this.launcherCryptoSelector);
            this.launcherPage.Controls.Add(this.stopButton);
            this.launcherPage.Controls.Add(this.launchButton);
            this.launcherPage.Location = new System.Drawing.Point(4, 24);
            this.launcherPage.Name = "launcherPage";
            this.launcherPage.Padding = new System.Windows.Forms.Padding(3);
            this.launcherPage.Size = new System.Drawing.Size(337, 332);
            this.launcherPage.TabIndex = 0;
            this.launcherPage.Text = "Launcher";
            this.launcherPage.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // launcherCryptoSelectLabel
            // 
            this.launcherCryptoSelectLabel.AutoSize = true;
            this.launcherCryptoSelectLabel.Location = new System.Drawing.Point(10, 11);
            this.launcherCryptoSelectLabel.Name = "launcherCryptoSelectLabel";
            this.launcherCryptoSelectLabel.Size = new System.Drawing.Size(104, 15);
            this.launcherCryptoSelectLabel.TabIndex = 3;
            this.launcherCryptoSelectLabel.Text = "Select Crypto Type";
            // 
            // launcherCryptoSelector
            // 
            this.launcherCryptoSelector.FormattingEnabled = true;
            this.launcherCryptoSelector.Items.AddRange(new object[] {
            "Ethereum",
            "Monero"});
            this.launcherCryptoSelector.Location = new System.Drawing.Point(10, 29);
            this.launcherCryptoSelector.Name = "launcherCryptoSelector";
            this.launcherCryptoSelector.Size = new System.Drawing.Size(320, 23);
            this.launcherCryptoSelector.TabIndex = 2;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(255, 301);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launchButton.Location = new System.Drawing.Point(119, 301);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
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
            this.cryptoTypePages.Location = new System.Drawing.Point(0, 3);
            this.cryptoTypePages.Name = "cryptoTypePages";
            this.cryptoTypePages.SelectedIndex = 0;
            this.cryptoTypePages.Size = new System.Drawing.Size(341, 333);
            this.cryptoTypePages.TabIndex = 0;
            // 
            // ethereumSetupPage
            // 
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
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(11, 59);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(319, 236);
            this.consoleTextBox.TabIndex = 6;
            this.consoleTextBox.Text = "";
            this.consoleTextBox.Invalidated += consoleWrite();
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "McDuck Crypto";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.launcherPage.ResumeLayout(false);
            this.launcherPage.PerformLayout();
            this.walletSetupPage.ResumeLayout(false);
            this.cryptoTypePages.ResumeLayout(false);
            this.ethereumSetupPage.ResumeLayout(false);
            this.ethereumSetupPage.PerformLayout();
            this.moneroSetupPage.ResumeLayout(false);
            this.moneroSetupPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage launcherPage;
        private System.Windows.Forms.TabPage walletSetupPage;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.TabControl cryptoTypePages;
        private System.Windows.Forms.TabPage ethereumSetupPage;
        private System.Windows.Forms.Label ethereumWalletAddressLabel;
        private System.Windows.Forms.TabPage moneroSetupPage;
        private System.Windows.Forms.TextBox ethereumWalletAddressInput;
        private System.Windows.Forms.Label launcherCryptoSelectLabel;
        private System.Windows.Forms.ComboBox launcherCryptoSelector;
        private System.Windows.Forms.TextBox ethereumPoolAddressInput;
        private System.Windows.Forms.Label ethereumPoolAddressLabel;
        private System.Windows.Forms.TextBox moneroPoolAddressInput;
        private System.Windows.Forms.Label moneroPoolAddressLabel;
        private System.Windows.Forms.TextBox moneroWalletAddressInput;
        private System.Windows.Forms.Label moneroWalletAddressLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox consoleTextBox;
    }
}

