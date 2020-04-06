namespace MemorizeWords
{
    partial class Addlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addlist));
            this.badd = new System.Windows.Forms.Button();
            this.tword = new System.Windows.Forms.TextBox();
            this.tmean = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.badd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.badd.Location = new System.Drawing.Point(150, 330);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(96, 34);
            this.badd.TabIndex = 2;
            this.badd.Text = "Add Words";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // tword
            // 
            this.tword.Location = new System.Drawing.Point(12, 44);
            this.tword.Multiline = true;
            this.tword.Name = "tword";
            this.tword.Size = new System.Drawing.Size(180, 280);
            this.tword.TabIndex = 3;
            // 
            // tmean
            // 
            this.tmean.Location = new System.Drawing.Point(200, 44);
            this.tmean.Multiline = true;
            this.tmean.Name = "tmean";
            this.tmean.Size = new System.Drawing.Size(180, 280);
            this.tmean.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter New Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(216, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter It\'s Meaning";
            // 
            // Addlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmean);
            this.Controls.Add(this.tword);
            this.Controls.Add(this.badd);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Addlist";
            this.Text = "Addlist";
            this.Load += new System.EventHandler(this.Addlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.TextBox tword;
        private System.Windows.Forms.TextBox tmean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}