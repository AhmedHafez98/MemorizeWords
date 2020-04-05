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
    public partial class Exam2 : Form
    {
        Main M;
        int Num;
        Dictionary<string, string> ans;
        public Exam2(Main m,int n)
        {
            InitializeComponent();
            M = m;
            Num = n;
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Visible = true;
        }
        bool cmp(string a, string b)
        {
            string aa = "", bb = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i])) ;
                char.ToLower(a[i]);
                if (a[i] != ' ')
                    aa += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (char.IsUpper(b[i])) ;
                char.ToLower(b[i]);
                if (b[i] != ' ')
                    bb += b[i];
            }
            return aa == bb;
        }
        private void Exam2_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainPage_FormClosed;
            ans = new Dictionary<string, string>();
            for (int i = 0; i < Num; i++)
            {
                ans.Add(M.dt.Rows[i][0].ToString(), M.dt.Rows[i][1].ToString());
                
            }
            Random rand = new Random();
            ans = ans.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
            foreach(var en in ans)
            {
                dataGridView1.Rows.Add("", en.Value);
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
            int i = 0;
            int cnt = 0;
          foreach(var en in ans)
            {
                if (cmp(dataGridView1.Rows[i].Cells[0].Value.ToString(), en.Key))
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    cnt++;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[0].Value += "->" + en.Key;
                }
                i++;
            }

            tgrade.Text = cnt.ToString() + " / " + ans.Count.ToString();
            tgrade.Visible = true;
        }
    }
}
