namespace KisProject
{
    partial class Számológép
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
            this.Number1 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(120, 297);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(99, 51);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(225, 297);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(99, 51);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(339, 297);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(99, 51);
            this.Number3.TabIndex = 2;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(339, 229);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(99, 51);
            this.Number6.TabIndex = 5;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(225, 229);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(99, 51);
            this.Number5.TabIndex = 4;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(120, 229);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(99, 51);
            this.Number4.TabIndex = 3;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            // 
            // Number9
            // 
            this.Number9.Location = new System.Drawing.Point(339, 163);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(99, 51);
            this.Number9.TabIndex = 8;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            // 
            // Number8
            // 
            this.Number8.Location = new System.Drawing.Point(225, 163);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(99, 51);
            this.Number8.TabIndex = 7;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            // 
            // Number7
            // 
            this.Number7.Location = new System.Drawing.Point(120, 163);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(99, 51);
            this.Number7.TabIndex = 6;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(120, 354);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(204, 51);
            this.Number0.TabIndex = 9;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(339, 354);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(99, 51);
            this.btnDecimal.TabIndex = 10;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // Számológép
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Számológép";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Számológép_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button btnDecimal;
    }
}

