using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PersonalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=GORKEM;Initial Catalog=PersonalDatabase;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personalDatabaseDataSet1.PersonalDatabase' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personalDatabaseTableAdapter.Fill(this.personalDatabaseDataSet1.PersonalDatabase);
            Form5 form = new Form5();
            form.Close();


        }
        bool Status;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into PersonalDatabase (PerName,PerSurname,PerCity,PerSalary,PerJob,PerStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            command.Parameters.AddWithValue("@p1",TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", CmbCity.Text);
            command.Parameters.AddWithValue("@p4", Convert.ToInt32(TxtSalary.Text));
            command.Parameters.AddWithValue("@p5", txtJob.Text);
            command.Parameters.AddWithValue("@p6", Status);
            command.ExecuteNonQuery();
            connection.Close();
            Status = false;
            MessageBox.Show("New data successfully inserted.");

            txtJob.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtSalary.Text = "";
            TxtID.Text = "";
            rdbMarried.Checked = false;
            rdbSingle.Checked = false;
            CmbCity.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.personalDatabaseTableAdapter.Fill(this.personalDatabaseDataSet1.PersonalDatabase);
        }

        private void rdbMarried_CheckedChanged(object sender, EventArgs e)
        {
            Status = true;
        }

        private void rdbSingle_CheckedChanged(object sender, EventArgs e)
        {
            Status = false;
        }
        bool click_checker;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (click_checker)
            {
                Form2 frm = new Form2();
                int choosen_index = dataGridView1.SelectedCells[0].RowIndex;
                frm.param_id = dataGridView1.Rows[choosen_index].Cells[0].Value.ToString();
                frm.param_name = dataGridView1.Rows[choosen_index].Cells[1].Value.ToString();
                frm.param_surname = dataGridView1.Rows[choosen_index].Cells[2].Value.ToString();
                frm.param_city = dataGridView1.Rows[choosen_index].Cells[3].Value.ToString();
                frm.param_salary = dataGridView1.Rows[choosen_index].Cells[4].Value.ToString();
                frm.param_status = dataGridView1.Rows[choosen_index].Cells[5].Value.ToString();
                frm.param_job = dataGridView1.Rows[choosen_index].Cells[6].Value.ToString();
                frm.Show();



            }
            click_checker = false;

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click_checker = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int delete_index = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[delete_index].Cells[0].Value.ToString();
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from PersonalDatabase Where PerId=@del0",connection);
            command.Parameters.AddWithValue("del0",id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully deleted");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtID.Text = "";
            TxtSalary.Text = "";
            TxtSurname.Text = "";
            txtJob.Text = "";
            rdbMarried.Checked = false;
            rdbSingle.Checked = false;
            CmbCity.Text = "";

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
