namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cmbMissing = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Location = new System.Drawing.Point(16, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(312, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(72, 16);
            this.numSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(104, 20);
            this.numSize.TabIndex = 3;
            this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbMissing
            // 
            this.cmbMissing.AllowDrop = true;
            this.cmbMissing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissing.FormattingEnabled = true;
            this.cmbMissing.Items.AddRange(new object[] {
            "Oppe til venstre",
            "Oppe til høyre",
            "Nede til venstre",
            "Nede til høyre",
            "Senter"});
            this.cmbMissing.Location = new System.Drawing.Point(72, 40);
            this.cmbMissing.Name = "cmbMissing";
            this.cmbMissing.Size = new System.Drawing.Size(104, 21);
            this.cmbMissing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Størrelse:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tomt felt:";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.Location = new System.Drawing.Point(184, 16);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(88, 48);
            this.btnSelectImage.TabIndex = 8;
            this.btnSelectImage.Text = "Velg bilde";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::WindowsFormsApplication1.Properties.Resources.tree_square;
            this.pic1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.tree_square;
            this.pic1.Location = new System.Drawing.Point(280, 16);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(47, 47);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 9;
            this.pic1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 130);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMissing);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Name = "frmMenu";
            this.Text = "Startmeny";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ComboBox cmbMissing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pic1;
    }
}