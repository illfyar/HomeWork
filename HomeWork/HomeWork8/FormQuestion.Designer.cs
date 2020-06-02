namespace HomeWork.HomeWork8
{
    partial class FormQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveQuestion = new System.Windows.Forms.ToolStripButton();
            this.closeFormButton = new System.Windows.Forms.ToolStripButton();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.pictureLie = new System.Windows.Forms.PictureBox();
            this.pictureTruth = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTruth)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveQuestion,
            this.closeFormButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveQuestion
            // 
            this.saveQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveQuestion.Image = ((System.Drawing.Image)(resources.GetObject("saveQuestion.Image")));
            this.saveQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveQuestion.Name = "saveQuestion";
            this.saveQuestion.Size = new System.Drawing.Size(23, 22);
            this.saveQuestion.Text = "&Сохранить";
            this.saveQuestion.Click += new System.EventHandler(this.saveQuestion_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeFormButton.Image = ((System.Drawing.Image)(resources.GetObject("closeFormButton.Image")));
            this.closeFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(40, 22);
            this.closeFormButton.Text = "Close";
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // textQuestion
            // 
            this.textQuestion.Location = new System.Drawing.Point(0, 28);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(800, 140);
            this.textQuestion.TabIndex = 1;
            this.textQuestion.TextChanged += new System.EventHandler(this.textQuestion_TextChanged);
            // 
            // pictureLie
            // 
            this.pictureLie.BackgroundImage = global::HomeWork.Properties.Resources.icons8_нравится_64___копия;
            this.pictureLie.Location = new System.Drawing.Point(479, 194);
            this.pictureLie.Name = "pictureLie";
            this.pictureLie.Size = new System.Drawing.Size(65, 63);
            this.pictureLie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLie.TabIndex = 7;
            this.pictureLie.TabStop = false;
            this.pictureLie.BackColorChanged += new System.EventHandler(this.pictureLie_BackColorChanged);
            this.pictureLie.Click += new System.EventHandler(this.pictureLie_Click);
            // 
            // pictureTruth
            // 
            this.pictureTruth.BackgroundImage = global::HomeWork.Properties.Resources.icons8_нравится_64;
            this.pictureTruth.Location = new System.Drawing.Point(256, 194);
            this.pictureTruth.Name = "pictureTruth";
            this.pictureTruth.Size = new System.Drawing.Size(67, 63);
            this.pictureTruth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureTruth.TabIndex = 6;
            this.pictureTruth.TabStop = false;
            this.pictureTruth.BackColorChanged += new System.EventHandler(this.pictureTruth_BackColorChanged);
            this.pictureTruth.Click += new System.EventHandler(this.pictureTruth_Click);
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLie);
            this.Controls.Add(this.pictureTruth);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTruth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveQuestion;
        private System.Windows.Forms.ToolStripButton closeFormButton;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.PictureBox pictureLie;
        private System.Windows.Forms.PictureBox pictureTruth;
    }
}