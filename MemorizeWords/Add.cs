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

namespace MemorizeWords
{
    public partial class Add : Form
    {
        Main M;
        public Add(Main m)
        {
            InitializeComponent();
            M = m;
        }
        DataTable x;
        private void Add_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainPage_FormClosed;
            
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Enabled = true;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            bool f = true;
            if (!tstchk(tword.Text))
            {
                tword.BackColor = Color.Red;
                f = false;
            }
            if (!tstchk(tmean.Text))
            {
                tmean.BackColor = Color.Red;
                f = false;
            }
            if (!f) return;
            DataRow dr = M.dt.NewRow();
            dr["ID"] = M.dt.Rows.Count+ 1;
            dr["Word"] = tword.Text;
            dr["Meaning"] = tmean.Text;
            try
            {
                M.dt.Rows.Add(dr);
            }
            catch
            {
                MessageBox.Show("You Entered this Word Before");
                tword.BackColor = Color.Red;
            }
            tword.Text = "";
            tmean.Text = "";
            tword.Focus();
           
        }
        bool tstchk(string t)
        {
            for(int i = 0; i < t.Length; i++)
            {
                if (Char.IsLetter(t[i]))
                    return true;
            }
            return false;
        }

        private void tword_TextChanged(object sender, EventArgs e)
        {
            tword.BackColor = Color.LightSteelBlue;
            
        }

        private void tmean_TextChanged(object sender, EventArgs e)
        {
            tmean.BackColor = Color.LightSteelBlue;
        }

        private void tword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                badd_Click(sender,e);
            }
        }

        private void tmean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                badd_Click(sender, e);
            }
        }
    }
}
