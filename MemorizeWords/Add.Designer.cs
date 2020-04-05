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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tword = new System.Windows.Forms.TextBox();
            this.tmean = new System.Windows.Forms.TextBox();
            this.badd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tword
            // 
            this.tword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.tword, "tword");
            this.tword.Name = "tword";
            this.tword.TextChanged += new System.EventHandler(this.tword_TextChanged);
            this.tword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tword_KeyDown);
            // 
            // tmean
            // 
            this.tmean.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.tmean, "tmean");
            this.tmean.Name = "tmean";
            this.tmean.TextChanged += new System.EventHandler(this.tmean_TextChanged);
            this.tmean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tmean_KeyDown);
            // 
            // badd
            // 
            resources.ApplyResources(this.badd, "badd");
            this.badd.Name = "badd";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.badd);
            this.Controls.Add(this.tmean);
            this.Controls.Add(this.tword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add";
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