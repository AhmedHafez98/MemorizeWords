using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorizeWords
{
    public partial class Exam1 : Form
    {
        Main M;
        Exam2 E;
        public Exam1(Main m)
        {
            InitializeComponent();
            M = m;
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Enabled = true;
        }
        private void Exam1_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainPage_FormClosed;
            spin1.Maximum = M.dt.Rows.Count;
        }

        private void bget_Click(object sender, EventArgs e)
        {
            if (spin1.Value > M.dt.Rows.Count)
            {
                MessageBox.Show("Number of Words Error");
                return;
            }
            E = new Exam2(M, (int)spin1.Value);
            E.Show();
            M.Visible=false;
            this.Close();
        }
    }
}
