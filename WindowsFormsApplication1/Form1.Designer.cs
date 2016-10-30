namespace WindowsFormsApplication1
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
            this.btnVerileriCek = new System.Windows.Forms.Button();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerileriCek
            // 
            this.btnVerileriCek.Location = new System.Drawing.Point(12, 53);
            this.btnVerileriCek.Name = "btnVerileriCek";
            this.btnVerileriCek.Size = new System.Drawing.Size(145, 23);
            this.btnVerileriCek.TabIndex = 0;
            this.btnVerileriCek.Text = "Verileri Çek";
            this.btnVerileriCek.UseVisualStyleBackColor = true;
            this.btnVerileriCek.Click += new System.EventHandler(this.btnVerileriCek_Click);
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 18;
            this.lstKisiler.Location = new System.Drawing.Point(12, 98);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(402, 238);
            this.lstKisiler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.btnVerileriCek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerileriCek;
        private System.Windows.Forms.ListBox lstKisiler;
    }
}

