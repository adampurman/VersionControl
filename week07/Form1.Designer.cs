namespace week07
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
            this.csvpathtxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.eredmenytxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zaroev = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.zaroev)).BeginInit();
            this.SuspendLayout();
            // 
            // csvpathtxt
            // 
            this.csvpathtxt.Location = new System.Drawing.Point(263, 33);
            this.csvpathtxt.Margin = new System.Windows.Forms.Padding(2);
            this.csvpathtxt.Name = "csvpathtxt";
            this.csvpathtxt.Size = new System.Drawing.Size(274, 20);
            this.csvpathtxt.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 24);
            this.button2.TabIndex = 12;
            this.button2.Text = "Böngészés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // eredmenytxt
            // 
            this.eredmenytxt.Location = new System.Drawing.Point(32, 63);
            this.eredmenytxt.Margin = new System.Windows.Forms.Padding(2);
            this.eredmenytxt.Multiline = true;
            this.eredmenytxt.Name = "eredmenytxt";
            this.eredmenytxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eredmenytxt.Size = new System.Drawing.Size(505, 318);
            this.eredmenytxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(541, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Népesség fájl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Záróév";
            // 
            // zaroev
            // 
            this.zaroev.Location = new System.Drawing.Point(81, 33);
            this.zaroev.Margin = new System.Windows.Forms.Padding(2);
            this.zaroev.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.zaroev.Name = "zaroev";
            this.zaroev.Size = new System.Drawing.Size(90, 20);
            this.zaroev.TabIndex = 7;
            this.zaroev.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 410);
            this.Controls.Add(this.csvpathtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eredmenytxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaroev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zaroev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox csvpathtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox eredmenytxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown zaroev;
    }
}

