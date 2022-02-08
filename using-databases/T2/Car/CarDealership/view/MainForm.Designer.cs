namespace CarDealership.view
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.fuelComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.engineDisplacementTextBox = new System.Windows.Forms.TextBox();
            this.dateOfRegistrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.engineDisplacementLabel = new System.Windows.Forms.Label();
            this.dateOfRegistrationLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.testConnectionToolStripMenuItem.Text = "Test connection";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.fuelComboBox);
            this.infoPanel.Controls.Add(this.colorComboBox);
            this.infoPanel.Controls.Add(this.fuelLabel);
            this.infoPanel.Controls.Add(this.colorLabel);
            this.infoPanel.Controls.Add(this.modelComboBox);
            this.infoPanel.Controls.Add(this.makeComboBox);
            this.infoPanel.Controls.Add(this.mileageTextBox);
            this.infoPanel.Controls.Add(this.engineDisplacementTextBox);
            this.infoPanel.Controls.Add(this.dateOfRegistrationDateTimePicker);
            this.infoPanel.Controls.Add(this.priceTextBox);
            this.infoPanel.Controls.Add(this.modelLabel);
            this.infoPanel.Controls.Add(this.makeLabel);
            this.infoPanel.Controls.Add(this.mileageLabel);
            this.infoPanel.Controls.Add(this.engineDisplacementLabel);
            this.infoPanel.Controls.Add(this.dateOfRegistrationLabel);
            this.infoPanel.Controls.Add(this.priceLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 27);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(206, 376);
            this.infoPanel.TabIndex = 1;
            // 
            // fuelComboBox
            // 
            this.fuelComboBox.FormattingEnabled = true;
            this.fuelComboBox.Location = new System.Drawing.Point(3, 350);
            this.fuelComboBox.Name = "fuelComboBox";
            this.fuelComboBox.Size = new System.Drawing.Size(121, 23);
            this.fuelComboBox.TabIndex = 15;
            this.fuelComboBox.SelectionChangeCommitted += new System.EventHandler(this.AnyOtherComboBox_SelectionChangeCommitted);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(3, 303);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 23);
            this.colorComboBox.TabIndex = 14;
            this.colorComboBox.SelectionChangeCommitted += new System.EventHandler(this.AnyOtherComboBox_SelectionChangeCommitted);
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new System.Drawing.Point(3, 332);
            this.fuelLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(32, 15);
            this.fuelLabel.TabIndex = 7;
            this.fuelLabel.Text = "Fuel:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(3, 285);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 15);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color:";
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(3, 256);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 23);
            this.modelComboBox.TabIndex = 13;
            this.modelComboBox.SelectionChangeCommitted += new System.EventHandler(this.AnyOtherComboBox_SelectionChangeCommitted);
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(3, 209);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(121, 23);
            this.makeComboBox.TabIndex = 12;
            this.makeComboBox.SelectionChangeCommitted += new System.EventHandler(this.makeComboBox_SelectionChangeCommitted);
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(3, 162);
            this.mileageTextBox.MaxLength = 7;
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 23);
            this.mileageTextBox.TabIndex = 11;
            this.mileageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnyControl_KeyPress);
            // 
            // engineDisplacementTextBox
            // 
            this.engineDisplacementTextBox.Location = new System.Drawing.Point(3, 115);
            this.engineDisplacementTextBox.MaxLength = 3;
            this.engineDisplacementTextBox.Name = "engineDisplacementTextBox";
            this.engineDisplacementTextBox.Size = new System.Drawing.Size(100, 23);
            this.engineDisplacementTextBox.TabIndex = 10;
            this.engineDisplacementTextBox.WordWrap = false;
            this.engineDisplacementTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnyControl_KeyPress);
            // 
            // dateOfRegistrationDateTimePicker
            // 
            this.dateOfRegistrationDateTimePicker.Location = new System.Drawing.Point(3, 68);
            this.dateOfRegistrationDateTimePicker.Name = "dateOfRegistrationDateTimePicker";
            this.dateOfRegistrationDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateOfRegistrationDateTimePicker.TabIndex = 9;
            this.dateOfRegistrationDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnyControl_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(3, 21);
            this.priceTextBox.MaxLength = 7;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.WordWrap = false;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnyControl_KeyPress);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(3, 238);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 15);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(3, 191);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(39, 15);
            this.makeLabel.TabIndex = 4;
            this.makeLabel.Text = "Make:";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(3, 144);
            this.mileageLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(52, 15);
            this.mileageLabel.TabIndex = 3;
            this.mileageLabel.Text = "Mileage:";
            // 
            // engineDisplacementLabel
            // 
            this.engineDisplacementLabel.AutoSize = true;
            this.engineDisplacementLabel.Location = new System.Drawing.Point(3, 97);
            this.engineDisplacementLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.engineDisplacementLabel.Name = "engineDisplacementLabel";
            this.engineDisplacementLabel.Size = new System.Drawing.Size(120, 15);
            this.engineDisplacementLabel.TabIndex = 2;
            this.engineDisplacementLabel.Text = "Engine displacement:";
            // 
            // dateOfRegistrationLabel
            // 
            this.dateOfRegistrationLabel.AutoSize = true;
            this.dateOfRegistrationLabel.Location = new System.Drawing.Point(3, 50);
            this.dateOfRegistrationLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dateOfRegistrationLabel.Name = "dateOfRegistrationLabel";
            this.dateOfRegistrationLabel.Size = new System.Drawing.Size(111, 15);
            this.dateOfRegistrationLabel.TabIndex = 1;
            this.dateOfRegistrationLabel.Text = "Date of registration:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(3, 3);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 15);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price:";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.errorLabel);
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Controls.Add(this.previousButton);
            this.buttonPanel.Controls.Add(this.deleteButton);
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Controls.Add(this.clearButton);
            this.buttonPanel.Location = new System.Drawing.Point(224, 27);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(227, 376);
            this.buttonPanel.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(3, 116);
            this.errorLabel.MaximumSize = new System.Drawing.Size(221, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(116, 90);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(108, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(3, 90);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(108, 23);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(221, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Location = new System.Drawing.Point(3, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(221, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Yellow;
            this.clearButton.Location = new System.Drawing.Point(3, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(221, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 415);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label engineDisplacementLabel;
        private System.Windows.Forms.Label dateOfRegistrationLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker dateOfRegistrationDateTimePicker;
        private System.Windows.Forms.TextBox engineDisplacementTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox fuelComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label errorLabel;
    }
}