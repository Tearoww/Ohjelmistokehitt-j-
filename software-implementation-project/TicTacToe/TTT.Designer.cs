namespace TicTacToe
{
    partial class TTT
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.bottomRight = new System.Windows.Forms.Button();
            this.bottom = new System.Windows.Forms.Button();
            this.bottomLeft = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.middle = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Button();
            this.topLeft = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(468, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayerToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // changePlayerToolStripMenuItem
            // 
            this.changePlayerToolStripMenuItem.Name = "changePlayerToolStripMenuItem";
            this.changePlayerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changePlayerToolStripMenuItem.Text = "Change player";
            this.changePlayerToolStripMenuItem.Click += new System.EventHandler(this.ChangePlayerToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitStripMenuItem.Text = "Exit";
            this.exitStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            // panel
            // 
            this.panel.Controls.Add(this.bottomRight);
            this.panel.Controls.Add(this.bottom);
            this.panel.Controls.Add(this.bottomLeft);
            this.panel.Controls.Add(this.right);
            this.panel.Controls.Add(this.middle);
            this.panel.Controls.Add(this.left);
            this.panel.Controls.Add(this.topRight);
            this.panel.Controls.Add(this.top);
            this.panel.Controls.Add(this.topLeft);
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(468, 468);
            this.panel.TabIndex = 1;
            // 
            // bottomRight
            // 
            this.bottomRight.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottomRight.Location = new System.Drawing.Point(313, 313);
            this.bottomRight.Margin = new System.Windows.Forms.Padding(1);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(154, 154);
            this.bottomRight.TabIndex = 8;
            this.bottomRight.TabStop = false;
            this.bottomRight.UseVisualStyleBackColor = true;
            this.bottomRight.Click += new System.EventHandler(this.Button_Click);
            // 
            // bottom
            // 
            this.bottom.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottom.Location = new System.Drawing.Point(157, 314);
            this.bottom.Margin = new System.Windows.Forms.Padding(1);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(154, 154);
            this.bottom.TabIndex = 7;
            this.bottom.TabStop = false;
            this.bottom.UseVisualStyleBackColor = true;
            this.bottom.Click += new System.EventHandler(this.Button_Click);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottomLeft.Location = new System.Drawing.Point(1, 314);
            this.bottomLeft.Margin = new System.Windows.Forms.Padding(1);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(154, 154);
            this.bottomLeft.TabIndex = 6;
            this.bottomLeft.TabStop = false;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.Click += new System.EventHandler(this.Button_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right.Location = new System.Drawing.Point(313, 157);
            this.right.Margin = new System.Windows.Forms.Padding(1);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(154, 154);
            this.right.TabIndex = 5;
            this.right.TabStop = false;
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.Button_Click);
            // 
            // middle
            // 
            this.middle.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middle.Location = new System.Drawing.Point(157, 157);
            this.middle.Margin = new System.Windows.Forms.Padding(1);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(154, 154);
            this.middle.TabIndex = 4;
            this.middle.TabStop = false;
            this.middle.UseVisualStyleBackColor = true;
            this.middle.Click += new System.EventHandler(this.Button_Click);
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left.Location = new System.Drawing.Point(1, 157);
            this.left.Margin = new System.Windows.Forms.Padding(1);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(154, 154);
            this.left.TabIndex = 3;
            this.left.TabStop = false;
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.Button_Click);
            // 
            // topRight
            // 
            this.topRight.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topRight.Location = new System.Drawing.Point(313, 1);
            this.topRight.Margin = new System.Windows.Forms.Padding(1);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(154, 154);
            this.topRight.TabIndex = 2;
            this.topRight.TabStop = false;
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.Button_Click);
            // 
            // top
            // 
            this.top.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top.Location = new System.Drawing.Point(157, 1);
            this.top.Margin = new System.Windows.Forms.Padding(1);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(154, 154);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            this.top.UseVisualStyleBackColor = true;
            this.top.Click += new System.EventHandler(this.Button_Click);
            // 
            // topLeft
            // 
            this.topLeft.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topLeft.Location = new System.Drawing.Point(1, 1);
            this.topLeft.Margin = new System.Windows.Forms.Padding(1);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(154, 154);
            this.topLeft.TabIndex = 0;
            this.topLeft.TabStop = false;
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.Button_Click);
            // 
            // TTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 492);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(484, 531);
            this.MinimumSize = new System.Drawing.Size(484, 531);
            this.Name = "TTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Shown += new System.EventHandler(this.TTT_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bottomRight;
        private System.Windows.Forms.Button bottom;
        private System.Windows.Forms.Button bottomLeft;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button middle;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button topRight;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.Button topLeft;
    }
}

