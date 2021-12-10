
namespace T1
{
    partial class Rekisterointi
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
            this.buttonRekisteroidy = new System.Windows.Forms.Button();
            this.buttonHae = new System.Windows.Forms.Button();
            this.SukunimitextBox = new System.Windows.Forms.TextBox();
            this.EtunimitextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sukunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opiskelijaryhmä = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpiskelijaryhmacomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRekisteroidy
            // 
            this.buttonRekisteroidy.Enabled = false;
            this.buttonRekisteroidy.Location = new System.Drawing.Point(548, 54);
            this.buttonRekisteroidy.Name = "buttonRekisteroidy";
            this.buttonRekisteroidy.Size = new System.Drawing.Size(121, 29);
            this.buttonRekisteroidy.TabIndex = 4;
            this.buttonRekisteroidy.Text = "Rekisteröidy";
            this.buttonRekisteroidy.UseVisualStyleBackColor = true;
            this.buttonRekisteroidy.Click += new System.EventHandler(this.buttonRekisteroidy_Click);
            // 
            // buttonHae
            // 
            this.buttonHae.Location = new System.Drawing.Point(86, 109);
            this.buttonHae.Name = "buttonHae";
            this.buttonHae.Size = new System.Drawing.Size(432, 29);
            this.buttonHae.TabIndex = 5;
            this.buttonHae.Text = "Hae";
            this.buttonHae.UseVisualStyleBackColor = true;
            this.buttonHae.Click += new System.EventHandler(this.buttonHae_Click);
            // 
            // SukunimitextBox
            // 
            this.SukunimitextBox.Location = new System.Drawing.Point(249, 56);
            this.SukunimitextBox.Name = "SukunimitextBox";
            this.SukunimitextBox.Size = new System.Drawing.Size(125, 27);
            this.SukunimitextBox.TabIndex = 2;
            this.SukunimitextBox.TextChanged += new System.EventHandler(this.Tekstikentta_teksipaivittyi);
            // 
            // EtunimitextBox
            // 
            this.EtunimitextBox.Location = new System.Drawing.Point(86, 56);
            this.EtunimitextBox.Name = "EtunimitextBox";
            this.EtunimitextBox.Size = new System.Drawing.Size(125, 27);
            this.EtunimitextBox.TabIndex = 1;
            this.EtunimitextBox.TextChanged += new System.EventHandler(this.Tekstikentta_teksipaivittyi);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Etunimi,
            this.Sukunimi,
            this.Opiskelijaryhmä});
            this.dataGridView1.Location = new System.Drawing.Point(86, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(557, 317);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Etunimi
            // 
            this.Etunimi.HeaderText = "Etunimi";
            this.Etunimi.MinimumWidth = 6;
            this.Etunimi.Name = "Etunimi";
            this.Etunimi.Width = 125;
            // 
            // Sukunimi
            // 
            this.Sukunimi.HeaderText = "Sukunimi";
            this.Sukunimi.MinimumWidth = 6;
            this.Sukunimi.Name = "Sukunimi";
            this.Sukunimi.Width = 125;
            // 
            // Opiskelijaryhmä
            // 
            this.Opiskelijaryhmä.HeaderText = "Opiskelijaryhmä";
            this.Opiskelijaryhmä.MinimumWidth = 6;
            this.Opiskelijaryhmä.Name = "Opiskelijaryhmä";
            this.Opiskelijaryhmä.Width = 125;
            // 
            // OpiskelijaryhmacomboBox
            // 
            this.OpiskelijaryhmacomboBox.FormattingEnabled = true;
            this.OpiskelijaryhmacomboBox.Location = new System.Drawing.Point(391, 56);
            this.OpiskelijaryhmacomboBox.Name = "OpiskelijaryhmacomboBox";
            this.OpiskelijaryhmacomboBox.Size = new System.Drawing.Size(151, 28);
            this.OpiskelijaryhmacomboBox.TabIndex = 3;
            this.OpiskelijaryhmacomboBox.DropDown += new System.EventHandler(this.OpiskelijaryhmacomboBox_DropDown);
            this.OpiskelijaryhmacomboBox.SelectionChangeCommitted += new System.EventHandler(this.OpiskelijaryhmacomboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opiskelijaryhmä";
            // 
            // Rekisterointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpiskelijaryhmacomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EtunimitextBox);
            this.Controls.Add(this.SukunimitextBox);
            this.Controls.Add(this.buttonHae);
            this.Controls.Add(this.buttonRekisteroidy);
            this.Name = "Rekisterointi";
            this.Text = "Rekisteröinti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRekisteroidy;
        private System.Windows.Forms.Button buttonHae;
        private System.Windows.Forms.TextBox SukunimitextBox;
        private System.Windows.Forms.TextBox EtunimitextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox OpiskelijaryhmacomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sukunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opiskelijaryhmä;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

