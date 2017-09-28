namespace Vidiogeim
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
            this.pctCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCanvas
            // 
            this.pctCanvas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pctCanvas.Location = new System.Drawing.Point(0, 0);
            this.pctCanvas.Name = "pctCanvas";
            this.pctCanvas.Size = new System.Drawing.Size(820, 600);
            this.pctCanvas.TabIndex = 0;
            this.pctCanvas.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(362, 599);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(480, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 80);
            this.label1.TabIndex = 2;
            this.label1.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(40, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 3;
            this.label2.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(460, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 20);
            this.label3.TabIndex = 4;
            this.label3.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(260, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(540, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 6;
            this.label5.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(180, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 80);
            this.label6.TabIndex = 7;
            this.label6.MouseEnter += new System.EventHandler(this.Colission);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblCont.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.Location = new System.Drawing.Point(366, 603);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(68, 46);
            this.lblCont.TabIndex = 8;
            this.lblCont.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pctCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCanvas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Timer timer1;
    }
}

