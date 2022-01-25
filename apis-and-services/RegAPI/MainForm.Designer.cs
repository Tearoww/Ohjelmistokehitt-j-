
namespace RegAPI
{
    partial class MainForm
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
            this.jokePanel = new System.Windows.Forms.Panel();
            this.jokeDeliveryLabel = new System.Windows.Forms.Label();
            this.jokeSetupLabel = new System.Windows.Forms.Label();
            this.jokeTitleLabel = new System.Windows.Forms.Label();
            this.regPanel = new System.Windows.Forms.Panel();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.jokePanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // jokePanel
            // 
            this.jokePanel.Controls.Add(this.jokeDeliveryLabel);
            this.jokePanel.Controls.Add(this.jokeSetupLabel);
            this.jokePanel.Controls.Add(this.jokeTitleLabel);
            this.jokePanel.Location = new System.Drawing.Point(12, 12);
            this.jokePanel.Name = "jokePanel";
            this.jokePanel.Size = new System.Drawing.Size(210, 93);
            this.jokePanel.TabIndex = 0;
            // 
            // jokeDeliveryLabel
            // 
            this.jokeDeliveryLabel.Location = new System.Drawing.Point(3, 60);
            this.jokeDeliveryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.jokeDeliveryLabel.MaximumSize = new System.Drawing.Size(214, 30);
            this.jokeDeliveryLabel.Name = "jokeDeliveryLabel";
            this.jokeDeliveryLabel.Size = new System.Drawing.Size(204, 30);
            this.jokeDeliveryLabel.TabIndex = 2;
            // 
            // jokeSetupLabel
            // 
            this.jokeSetupLabel.Location = new System.Drawing.Point(3, 24);
            this.jokeSetupLabel.Margin = new System.Windows.Forms.Padding(3);
            this.jokeSetupLabel.MaximumSize = new System.Drawing.Size(214, 30);
            this.jokeSetupLabel.Name = "jokeSetupLabel";
            this.jokeSetupLabel.Size = new System.Drawing.Size(204, 30);
            this.jokeSetupLabel.TabIndex = 1;
            // 
            // jokeTitleLabel
            // 
            this.jokeTitleLabel.AutoSize = true;
            this.jokeTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.jokeTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.jokeTitleLabel.Name = "jokeTitleLabel";
            this.jokeTitleLabel.Size = new System.Drawing.Size(89, 15);
            this.jokeTitleLabel.TabIndex = 0;
            this.jokeTitleLabel.Text = "Joke of the day:";
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.probabilityLabel);
            this.regPanel.Controls.Add(this.resultLabel);
            this.regPanel.Controls.Add(this.registerButton);
            this.regPanel.Controls.Add(this.genderComboBox);
            this.regPanel.Controls.Add(this.ageUpDown);
            this.regPanel.Controls.Add(this.ageLabel);
            this.regPanel.Controls.Add(this.genderLabel);
            this.regPanel.Controls.Add(this.lastNameTextBox);
            this.regPanel.Controls.Add(this.lastNameLabel);
            this.regPanel.Controls.Add(this.firstNameTextBox);
            this.regPanel.Controls.Add(this.firstNameLabel);
            this.regPanel.Location = new System.Drawing.Point(12, 111);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(210, 166);
            this.regPanel.TabIndex = 1;
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.Location = new System.Drawing.Point(147, 64);
            this.probabilityLabel.MaximumSize = new System.Drawing.Size(60, 15);
            this.probabilityLabel.MinimumSize = new System.Drawing.Size(60, 15);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(60, 15);
            this.probabilityLabel.TabIndex = 12;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(3, 148);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resultLabel.MaximumSize = new System.Drawing.Size(204, 15);
            this.resultLabel.MinimumSize = new System.Drawing.Size(204, 15);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(204, 15);
            this.resultLabel.TabIndex = 11;
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(3, 119);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(204, 23);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox.Location = new System.Drawing.Point(74, 61);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(67, 23);
            this.genderComboBox.TabIndex = 8;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(74, 90);
            this.ageUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(38, 23);
            this.ageUpDown.TabIndex = 9;
            this.ageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(3, 92);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(31, 15);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(3, 64);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "Gender:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(74, 32);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(133, 23);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 35);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 15);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(74, 3);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(133, 23);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 6);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(65, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 289);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.jokePanel);
            this.MaximumSize = new System.Drawing.Size(250, 328);
            this.MinimumSize = new System.Drawing.Size(250, 328);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegAPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jokePanel.ResumeLayout(false);
            this.jokePanel.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel jokePanel;
        private System.Windows.Forms.Label jokeDeliveryLabel;
        private System.Windows.Forms.Label jokeSetupLabel;
        private System.Windows.Forms.Label jokeTitleLabel;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label probabilityLabel;
    }
}

