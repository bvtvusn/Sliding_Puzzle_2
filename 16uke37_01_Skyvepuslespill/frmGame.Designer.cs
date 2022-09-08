namespace WindowsFormsApplication1
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            this.tmrSec = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.txtCounter2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tmrSec
            // 
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Location = new System.Drawing.Point(128, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(227, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtCounter
            // 
            this.txtCounter.BackColor = System.Drawing.Color.White;
            this.txtCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter.Location = new System.Drawing.Point(56, 65);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(50, 24);
            this.txtCounter.TabIndex = 2;
            this.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(184, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(112, 30);
            this.txtTime.TabIndex = 3;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMix.Location = new System.Drawing.Point(400, 40);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(50, 50);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "Bland";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // txtCounter2
            // 
            this.txtCounter2.BackColor = System.Drawing.Color.White;
            this.txtCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter2.Location = new System.Drawing.Point(56, 40);
            this.txtCounter2.Name = "txtCounter2";
            this.txtCounter2.ReadOnly = true;
            this.txtCounter2.Size = new System.Drawing.Size(50, 24);
            this.txtCounter2.TabIndex = 6;
            this.txtCounter2.Text = "Trekk:";
            this.txtCounter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGame
            // 
            this.ClientSize = new System.Drawing.Size(506, 615);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.txtCounter2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.Resize += new System.EventHandler(this.game_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.TextBox txtCounter2;
    }
}