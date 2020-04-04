using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemorizeWords;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MemorizeWords
{
    public partial class Main : Form
    {
        // Forms
        Add addform;
        Exam1 Exam1form;
        Remove Removeform;

        public Main()
        {
            InitializeComponent();
        }
        // database 
        db mydb;
        public DataTable dt;
        BindingSource bs = new BindingSource();
        
        private void Main_Load(object sender, EventArgs e)
        {
            mydb = new db("dic");
            dt = mydb.Get();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            this.FormClosed += MainPage_FormClosed;
            this.Width = dataGridView1.Columns[0].Width +
                dataGridView1.Columns[1].Width +
                dataGridView1.Columns[2].Width+18;
            dataGridView1.Width = this.Width;
            

        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mydb.UDT(dt);
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            addform = new Add(this);
            addform.Show();
        }
    }
}
