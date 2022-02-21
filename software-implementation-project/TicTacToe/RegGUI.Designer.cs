namespace TicTacToe
{
    partial class RegGUI
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
            this.panel = new System.Windows.Forms.Panel();
            this.registerRadioButton = new System.Windows.Forms.RadioButton();
            this.loginRadioButton = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.registerRadioButton);
            this.panel.Controls.Add(this.loginRadioButton);
            this.panel.Controls.Add(this.resultLabel);
            this.panel.Controls.Add(this.button);
            this.panel.Controls.Add(this.passwordTextBox);
            this.panel.Controls.Add(this.passwordLabel);
            this.panel.Controls.Add(this.nicknameTextBox);
            this.panel.Controls.Add(this.nicknameLabel);
            this.panel.Location = new System.Drawing.Point(12, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(323, 108);
            this.panel.TabIndex = 0;
            // 
            // registerRadioButton
            // 
            this.registerRadioButton.AutoSize = true;
            this.registerRadioButton.Location = new System.Drawing.Point(64, 63);
            this.registerRadioButton.Name = "registerRadioButton";
            this.registerRadioButton.Size = new System.Drawing.Size(67, 19);
            this.registerRadioButton.TabIndex = 5;
            this.registerRadioButton.Text = "Register";
            this.registerRadioButton.UseVisualStyleBackColor = true;
            this.registerRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // loginRadioButton
            // 
            this.loginRadioButton.AutoSize = true;
            this.loginRadioButton.Checked = true;
            this.loginRadioButton.Location = new System.Drawing.Point(3, 63);
            this.loginRadioButton.Name = "loginRadioButton";
            this.loginRadioButton.Size = new System.Drawing.Size(55, 19);
            this.loginRadioButton.TabIndex = 4;
            this.loginRadioButton.TabStop = true;
            this.loginRadioButton.Text = "Login";
            this.loginRadioButton.UseVisualStyleBackColor = true;
            this.loginRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(3, 90);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(317, 15);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(137, 61);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(183, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Login";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(73, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(247, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 35);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(73, 3);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(123, 23);
            this.nicknameTextBox.TabIndex = 1;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(3, 6);
            this.nicknameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(64, 15);
            this.nicknameLabel.TabIndex = 0;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(347, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // RegGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 147);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(363, 186);
            this.MinimumSize = new System.Drawing.Size(363, 186);
            this.Name = "RegGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.RadioButton registerRadioButton;
        private System.Windows.Forms.RadioButton loginRadioButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
    }
}