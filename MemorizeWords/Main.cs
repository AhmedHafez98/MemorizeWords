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
using System.Speech;
using System.Speech.Synthesis;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MemorizeWords
{
    public partial class Main : Form
    {
        // Forms
        Add addform;
        Exam1 Exam1form;
        Removef Removeform;

        public Main()
        {
            InitializeComponent();
        }
        // database 
        public db mydb;
        public DataTable dt;
        BindingSource bs = new BindingSource();
        public AutoCompleteStringCollection Enwords;
        
        private void Main_Load(object sender, EventArgs e)
        {
            mydb = new db("dic");
            dt = mydb.Get();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            this.FormClosed += MainPage_FormClosed;
            this.Width = dataGridView1.Columns[0].Width +
                dataGridView1.Columns[1].Width +
                dataGridView1.Columns[2].Width+18;
            dataGridView1.Width = this.Width;
            // add autocomplete
            Enwords = new AutoCompleteStringCollection();
            DataTable autodt = mydb.Autocomp();
            foreach(DataRow dr in autodt.Rows)
            {
                if(dr["Word"].ToString()!="")
                Enwords.Add(dr["Word"].ToString());
            }
            

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

        private void remove_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Removeform = new Removef(this);
            Removeform.Show();
        }

        private void test_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Exam1form = new Exam1(this);
            Exam1form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.SpeakAsync(dataGridView1.CurrentCell.Value.ToString());
        }
    }
}
