
namespace T1
{
    partial class mainForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.studentGroupComboBox = new System.Windows.Forms.ComboBox();
            this.studentGroupLabel = new System.Windows.Forms.Label();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.queryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(3, 21);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(144, 23);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(153, 21);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(144, 23);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(3, 50);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(444, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 3);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(65, 15);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(153, 3);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 15);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last name:";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.studentGroupComboBox);
            this.inputPanel.Controls.Add(this.studentGroupLabel);
            this.inputPanel.Controls.Add(this.registerButton);
            this.inputPanel.Controls.Add(this.lastNameLabel);
            this.inputPanel.Controls.Add(this.firstNameTextBox);
            this.inputPanel.Controls.Add(this.firstNameLabel);
            this.inputPanel.Controls.Add(this.lastNameTextBox);
            this.inputPanel.Location = new System.Drawing.Point(12, 12);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(450, 76);
            this.inputPanel.TabIndex = 1;
            // 
            // studentGroupComboBox
            // 
            this.studentGroupComboBox.FormattingEnabled = true;
            this.studentGroupComboBox.Location = new System.Drawing.Point(303, 21);
            this.studentGroupComboBox.Name = "studentGroupComboBox";
            this.studentGroupComboBox.Size = new System.Drawing.Size(144, 23);
            this.studentGroupComboBox.TabIndex = 7;
            this.studentGroupComboBox.SelectionChangeCommitted += new System.EventHandler(this.studentGroupComboBox_SelectionChangeCommitted);
            this.studentGroupComboBox.Enter += new System.EventHandler(this.studentGroupComboBox_Enter);
            // 
            // studentGroupLabel
            // 
            this.studentGroupLabel.AutoSize = true;
            this.studentGroupLabel.Location = new System.Drawing.Point(303, 3);
            this.studentGroupLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.studentGroupLabel.Name = "studentGroupLabel";
            this.studentGroupLabel.Size = new System.Drawing.Size(86, 15);
            this.studentGroupLabel.TabIndex = 4;
            this.studentGroupLabel.Text = "Student group:";
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.queryButton);
            this.outputPanel.Controls.Add(this.dataGridView1);
            this.outputPanel.Location = new System.Drawing.Point(12, 94);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(450, 218);
            this.outputPanel.TabIndex = 9;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(3, 3);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(444, 23);
            this.queryButton.TabIndex = 10;
            this.queryButton.Text = "Retrieve database entries";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first_name,
            this.last_name,
            this.student_group});
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(444, 183);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last name";
            this.last_name.Name = "last_name";
            // 
            // student_group
            // 
            this.student_group.HeaderText = "Student Group";
            this.student_group.Name = "student_group";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 324);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.inputPanel);
            this.MaximumSize = new System.Drawing.Size(491, 363);
            this.MinimumSize = new System.Drawing.Size(491, 363);
            this.Name = "mainForm";
            this.Text = "Registration";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.ComboBox studentGroupComboBox;
        private System.Windows.Forms.Label studentGroupLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_group;
    }
}

