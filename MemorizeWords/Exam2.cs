using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MemorizeWords
{
    public partial class Exam2 : Form
    {
        Main M;
        int Num;
        Dictionary<string, string> ans;
        System.Timers.Timer t;
        int th, tm, ts;
        public Exam2(Main m,int n)
        {
            InitializeComponent();
            M = m;
            Num = n;
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Visible = true;
            t.Stop();
            
        }
        bool cmp(string a, string b)
        {
            string aa = "", bb = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i])) ;
                
                if (a[i] != ' ')
                    aa += char.ToLower(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (char.IsUpper(b[i])) ;
                
                if (b[i] != ' ')
                    bb += char.ToLower(b[i]);
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
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ts += 1;
                if (ts == 60) {
                    ts = 0; tm += 1; }
                if (tm == 60)
                {
                    tm = 0;th += 1;
                }
                ttimer.Text = string.Format("{0}:{1}:{2}", th.ToString().PadLeft(2,'0'), tm.ToString().PadLeft(2,'0'), ts.ToString().PadLeft(2,'0'));
            }));
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
                    dataGridView1.Rows[i].Visible = false;
                    cnt++;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Crimson;
                    dataGridView1.Rows[i].Cells[0].Value += "  -->  " + en.Key;
                }
                dataGridView1.Rows[i].Cells[0].Selected = false;
                i++;
            }

            tgrade.Text = cnt.ToString() + " / " + ans.Count.ToString();
            tgrade.Visible = true;
            //dataGridView1.Rows[0].Cells[1].Selected=true;
            badd.Enabled = false;
            t.Stop();
        }
    }
}
