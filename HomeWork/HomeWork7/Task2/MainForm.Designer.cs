namespace HomeWork.HomeWork7.Task2
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
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelOver = new System.Windows.Forms.Label();
            this.labelLess = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.countAttempts = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(28, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOver.Location = new System.Drawing.Point(50, 75);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(70, 20);
            this.labelOver.TabIndex = 2;
            this.labelOver.Text = "Больше";
            // 
            // labelLess
            // 
            this.labelLess.AutoSize = true;
            this.labelLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLess.Location = new System.Drawing.Point(50, 137);
            this.labelLess.Name = "labelLess";
            this.labelLess.Size = new System.Drawing.Size(71, 20);
            this.labelLess.TabIndex = 3;
            this.labelLess.Text = "Меньше";
            // 
            // Check
            // 
            this.Check.Enabled = false;
            this.Check.Location = new System.Drawing.Point(28, 180);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(114, 26);
            this.Check.TabIndex = 4;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Location = new System.Drawing.Point(175, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(226, 178);
            this.textBox2.TabIndex = 5;
            // 
            // countAttempts
            // 
            this.countAttempts.AutoSize = true;
            this.countAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countAttempts.Location = new System.Drawing.Point(76, 37);
            this.countAttempts.Name = "countAttempts";
            this.countAttempts.Size = new System.Drawing.Size(18, 20);
            this.countAttempts.TabIndex = 6;
            this.countAttempts.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 217);
            this.Controls.Add(this.countAttempts);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.labelLess);
            this.Controls.Add(this.labelOver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelLess;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label countAttempts;
    }
}