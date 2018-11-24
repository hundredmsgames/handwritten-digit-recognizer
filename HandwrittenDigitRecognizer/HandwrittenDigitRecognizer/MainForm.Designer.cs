namespace HandwrittenDigitRecognizer
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Reset = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new HandwrittenDigitRecognizer.DrawingPanel();
            this.pbProccessedImage = new System.Windows.Forms.PictureBox();
            this.chcBProcessingActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProccessedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(50, 210);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(89, 33);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuess.Location = new System.Drawing.Point(46, 247);
            this.lblGuess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(142, 26);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "This is 99% 3";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(468, 31);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(2);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(91, 173);
            this.lstOutput.TabIndex = 3;
            this.lstOutput.SelectedIndexChanged += new System.EventHandler(this.lstOutput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(153, 210);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(89, 33);
            this.Button_Next.TabIndex = 5;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proccessed";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // pbProccessedImage
            // 
            this.pbProccessedImage.Location = new System.Drawing.Point(259, 12);
            this.pbProccessedImage.Name = "pbProccessedImage";
            this.pbProccessedImage.Size = new System.Drawing.Size(192, 192);
            this.pbProccessedImage.TabIndex = 6;
            this.pbProccessedImage.TabStop = false;
            // 
            // chcBProcessingActive
            // 
            this.chcBProcessingActive.AutoSize = true;
            this.chcBProcessingActive.Location = new System.Drawing.Point(273, 225);
            this.chcBProcessingActive.Name = "chcBProcessingActive";
            this.chcBProcessingActive.Size = new System.Drawing.Size(117, 17);
            this.chcBProcessingActive.TabIndex = 7;
            this.chcBProcessingActive.Text = "Proccessing Active";
            this.chcBProcessingActive.UseVisualStyleBackColor = true;
            this.chcBProcessingActive.CheckedChanged += new System.EventHandler(this.chcBProcessingActive_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 290);
            this.Controls.Add(this.chcBProcessingActive);
            this.Controls.Add(this.pbProccessedImage);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbProccessedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrawingPanel panel1;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbProccessedImage;
        private System.Windows.Forms.CheckBox chcBProcessingActive;
    }
}

