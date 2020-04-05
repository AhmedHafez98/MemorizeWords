namespace MemorizeWords
{
    partial class Exam1
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
            this.label1 = new System.Windows.Forms.Label();
            this.spin1 = new System.Windows.Forms.NumericUpDown();
            this.bget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spin1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Number of Words";
            // 
            // spin1
            // 
            this.spin1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spin1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin1.Location = new System.Drawing.Point(242, 35);
            this.spin1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(69, 22);
            this.spin1.TabIndex = 2;
            this.spin1.TabStop = false;
            this.spin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spin1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bget
            // 
            this.bget.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.bget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bget.Location = new System.Drawing.Point(121, 86);
            this.bget.Name = "bget";
            this.bget.Size = new System.Drawing.Size(98, 31);
            this.bget.TabIndex = 5;
            this.bget.Text = "Get Test";
            this.bget.UseVisualStyleBackColor = true;
            this.bget.Click += new System.EventHandler(this.bget_Click);
            // 
            // Exam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 169);
            this.Controls.Add(this.bget);
            this.Controls.Add(this.spin1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Exam1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam1";
            this.Load += new System.EventHandler(this.Exam1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spin1;
        private System.Windows.Forms.Button bget;
    }
}