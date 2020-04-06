namespace MemorizeWords
{
    partial class Exam2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttimer = new System.Windows.Forms.TextBox();
            this.badd = new System.Windows.Forms.Button();
            this.tgrade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gword,
            this.gmean});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(398, 356);
            this.dataGridView1.TabIndex = 1;
            // 
            // gword
            // 
            this.gword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gword.HeaderText = "Word";
            this.gword.Name = "gword";
            // 
            // gmean
            // 
            this.gmean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gmean.HeaderText = "Meaning";
            this.gmean.Name = "gmean";
            this.gmean.ReadOnly = true;
            this.gmean.Width = 72;
            // 
            // ttimer
            // 
            this.ttimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttimer.Enabled = false;
            this.ttimer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.ttimer.Location = new System.Drawing.Point(12, 373);
            this.ttimer.Name = "ttimer";
            this.ttimer.Size = new System.Drawing.Size(78, 26);
            this.ttimer.TabIndex = 3;
            this.ttimer.Text = "00:00:00";
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.badd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.badd.Location = new System.Drawing.Point(144, 370);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(98, 31);
            this.badd.TabIndex = 5;
            this.badd.Text = "Finish";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // tgrade
            // 
            this.tgrade.BackColor = System.Drawing.Color.LightGreen;
            this.tgrade.Enabled = false;
            this.tgrade.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgrade.Location = new System.Drawing.Point(271, 369);
            this.tgrade.Name = "tgrade";
            this.tgrade.Size = new System.Drawing.Size(95, 30);
            this.tgrade.TabIndex = 6;
            this.tgrade.Visible = false;
            // 
            // Exam2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 411);
            this.Controls.Add(this.tgrade);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.ttimer);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Exam2";
            this.Text = "Exam2";
            this.Load += new System.EventHandler(this.Exam2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ttimer;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gword;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmean;
        private System.Windows.Forms.TextBox tgrade;
    }
}