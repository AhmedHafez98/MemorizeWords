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
    public partial class Removef : Form
    {
        Main M;
        public Removef(Main m)
        {
            InitializeComponent();
            M = m;
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainPage_FormClosed;
            DataGridViewCheckBoxColumn dc = new DataGridViewCheckBoxColumn();
            dc.HeaderText = "Delete";
            dataGridView1.Columns.Add(dc);
            foreach (DataRow dr in M.dt.Rows)
                dataGridView1.Rows.Add(dr["Word"].ToString(),false);
           
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            M.Enabled = true;
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            List<int> lst=new List<int>();
            for(int i = dataGridView1.Rows.Count-1; i>=0 ; i--)
            {
                bool f = (bool)dataGridView1.Rows[i].Cells[1].Value;
                if (f)
                {
                    lst.Add(i);
                    M.dt.Rows.Find(dataGridView1.Rows[i].Cells[0].Value.ToString()).Delete();
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            for (int i = 0; i < M.dt.Rows.Count; i++)
                M.dt.Rows[i]["ID"] = i + 1;
            


        }
    }
}
