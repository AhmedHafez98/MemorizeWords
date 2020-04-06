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
    public partial class Addlist : Form
    {
        Main M;
        Add A;
        List<string> Words, Means;
        public Addlist(Main m,Add a )
        {
            InitializeComponent();
            M = m;
            A = a;
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Enabled = true;
        }
        private void Addlist_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainPage_FormClosed;
            M.Enabled = false;
            
        }

        private void badd_Click(object sender, EventArgs e)
        {
            Words = new List<string>();
            Means = new List<string>();
            // add to lists
            foreach (var i in tword.Lines)
                if (tstchk(i))
                    Words.Add(i);
            foreach (var i in tmean.Lines)
                if (tstchk(i))
                    Means.Add(i);
            // valid lists ?
            if (Words.Count != Means.Count)
            {
                MessageBox.Show("Invalid Enters");
                return;
            }
            // add to datatable
            bool f = false;
            for(int i = 0; i < Words.Count; i++)
            {
                DataRow dr = M.dt.NewRow();
                dr["ID"] = M.dt.Rows.Count + 1;
                dr["Word"] = Words[i];
                dr["Meaning"] = Means[i];
                try
                {
                    
                    M.dt.Rows.Add(dr);
                }
                catch
                {
                    f = true;   
                }
            }
            tword.Text = "";
            tmean.Text = "";
        }

        bool tstchk(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (Char.IsLetter(t[i]))
                    return true;
            }
            return false;
        }
    }
}
