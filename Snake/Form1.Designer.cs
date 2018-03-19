namespace Snake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gcanvas = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.gTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblgameover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Gcanvas
            // 
            this.Gcanvas.BackColor = System.Drawing.SystemColors.GrayText;
            this.Gcanvas.Location = new System.Drawing.Point(13, 13);
            this.Gcanvas.Name = "Gcanvas";
            this.Gcanvas.Size = new System.Drawing.Size(629, 576);
            this.Gcanvas.TabIndex = 0;
            this.Gcanvas.TabStop = false;
            this.Gcanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Gcanvas_paint);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(665, 21);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(115, 35);
            this.score.TabIndex = 1;
            this.score.Text = "Score :";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(867, 23);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 33);
            this.lblscore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.Location = new System.Drawing.Point(665, 475);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(202, 31);
            this.lblgameover.TabIndex = 4;
            this.lblgameover.Text = "LabelGameOver";
            this.lblgameover.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1014, 593);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Gcanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake in C#";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gcanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Gcanvas;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer gTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgameover;
    }
}

