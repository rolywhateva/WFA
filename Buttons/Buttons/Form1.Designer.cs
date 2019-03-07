namespace Buttons
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
            this.b1 = new System.Windows.Forms.Button();
            this.IndicationLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(81, 81);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(130, 53);
            this.b1.TabIndex = 0;
            this.b1.Text = "Apasa";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // IndicationLabel
            // 
            this.IndicationLabel.AutoSize = true;
            this.IndicationLabel.Location = new System.Drawing.Point(13, 471);
            this.IndicationLabel.Name = "IndicationLabel";
            this.IndicationLabel.Size = new System.Drawing.Size(43, 13);
            this.IndicationLabel.TabIndex = 1;
            this.IndicationLabel.Text = "Indicatii";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(336, 291);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(46, 13);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Rezultat";
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(315, 81);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(130, 53);
            this.b2.TabIndex = 3;
            this.b2.Text = "Apasa";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(545, 81);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(130, 53);
            this.b3.TabIndex = 4;
            this.b3.Text = "Apasa";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseEnter += new System.EventHandler(this.b3_MouseEnter);
            this.b3.MouseLeave += new System.EventHandler(this.b3_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 496);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IndicationLabel);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label IndicationLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
    }
}

