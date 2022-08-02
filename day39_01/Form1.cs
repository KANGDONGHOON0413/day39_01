using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day39_01
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet Dset;
        SqlCommandBuilder SCB; // 테이블 한개당 빌더역시 하나를 생성해 준다.

        string connstring = "server = .\\SQLEXPRESS; database = test; uid = sa; password = alencia;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            Dset = new DataSet();
            DA = new SqlDataAdapter("SELECT * FROM testTable02", conn);
            SCB = new SqlCommandBuilder(DA);
            
            DA.Fill(Dset, "testTable02");
            dataGridView1.DataSource = Dset.Tables[0];
        }

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            DataRow NewRow = Dset.Tables["testTable02"].NewRow();
            NewRow["Nid"] = int.Parse(INPUT_Nid.Text);
            NewRow["Name"] = INPUT_Name.Text;
            NewRow["Age"] = int.Parse(INPUT_Age.Text);
            Dset.Tables[0].Rows.Add(NewRow);
            DA.Update(Dset, "testTable02");

            Dset.Clear();
            DA.Fill(Dset, "testTable02");
            dataGridView1.DataSource = Dset.Tables[0];
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            int Nid = (int)dataGridView1.CurrentRow.Cells["Nid"].Value;
            string Filter = "Nid = " + Nid;
            DataRow[] FindRow = Dset.Tables["testTable02"].Select(Filter);
            FindRow[0]["Name"] = INPUT_Name.Text;
            FindRow[0]["Age"] = int.Parse(INPUT_Age.Text);

            DA.Update(Dset, "testTable02");
            dataGridView1.DataSource = Dset.Tables["testTable02"];
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            int Nid = (int)dataGridView1.CurrentRow.Cells["Nid"].Value;
            string Filter = "Nid = " + Nid;
            DataRow[] FindRow = Dset.Tables["testTable02"].Select(Filter);
            FindRow[0].Delete();

            DA.Update(Dset, "testTable02");
            dataGridView1.DataSource = Dset.Tables["testTable02"];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            INPUT_Nid.Text = dataGridView1.CurrentRow.Cells["Nid"].Value.ToString();
            INPUT_Name.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            INPUT_Age.Text = dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
        }
    }
}
