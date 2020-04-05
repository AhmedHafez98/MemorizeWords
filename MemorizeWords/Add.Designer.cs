namespace MemorizeWords
{
    partial class Add
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
            this.label2 = new System.Windows.Forms.Label();
            this.tword = new System.Windows.Forms.TextBox();
            this.tmean = new System.Windows.Forms.TextBox();
            this.badd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter It\'s Meaning";
            // 
            // tword
            // 
            this.tword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tword.Location = new System.Drawing.Point(86, 57);
            this.tword.Name = "tword";
            this.tword.Size = new System.Drawing.Size(160, 26);
            this.tword.TabIndex = 2;
            this.tword.TextChanged += new System.EventHandler(this.tword_TextChanged);
            this.tword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tword_KeyDown);
            // 
            // tmean
            // 
            this.tmean.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tmean.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmean.Location = new System.Drawing.Point(86, 130);
            this.tmean.Name = "tmean";
            this.tmean.Size = new System.Drawing.Size(160, 26);
            this.tmean.TabIndex = 3;
            this.tmean.TextChanged += new System.EventHandler(this.tmean_TextChanged);
            this.tmean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tmean_KeyDown);
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(186, 173);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(98, 31);
            this.badd.TabIndex = 4;
            this.badd.Text = "Add Word";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 216);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.tmean);
            this.Controls.Add(this.tword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tword;
        private System.Windows.Forms.TextBox tmean;
        private System.Windows.Forms.Button badd;
    }
}