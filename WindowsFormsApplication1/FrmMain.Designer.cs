namespace WindowsFormsApplication1
{
    partial class FrmMain
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
            this.SourceText = new System.Windows.Forms.TextBox();
            this.ChiperText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(28, 49);
            this.SourceText.MaxLength = 1073741824;
            this.SourceText.Multiline = true;
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(1041, 320);
            this.SourceText.TabIndex = 0;
            this.SourceText.TextChanged += new System.EventHandler(this.SourceText_TextChanged);
            // 
            // ChiperText
            // 
            this.ChiperText.Location = new System.Drawing.Point(28, 400);
            this.ChiperText.MaxLength = 1073741824;
            this.ChiperText.Multiline = true;
            this.ChiperText.Name = "ChiperText";
            this.ChiperText.Size = new System.Drawing.Size(1041, 320);
            this.ChiperText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reverse Transform";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1095, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Copy This";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1095, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Copy That";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 732);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChiperText);
            this.Controls.Add(this.SourceText);
            this.Name = "FrmMain";
            this.Text = "Simple Substitution";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox ChiperText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

