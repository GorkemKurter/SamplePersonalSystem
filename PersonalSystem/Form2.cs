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

namespace PersonalSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string param_name;
        public string param_surname;
        public string param_city;
        public string param_salary;
        public string param_job;
        public string param_status;
        public string param_id;

        private void Form2_Load(object sender, EventArgs e)
        {
            txt2Name.Text = param_name;
            txt2City.Text = param_city;
            txt2Salary.Text = param_salary;
            txt2Surname.Text = param_surname;
            txt2Job.Text = param_job;
            if(param_status == "True")
            {
                rdb2Married.Checked = true;
            
            
            }
            else
            {
                rdb2Single.Checked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool status_update;
        private void btnf2Update_Click(object sender, EventArgs e)
        {
            int param_updated_id;
            param_updated_id = Convert.ToInt32(param_id);
            SqlConnection connection_update = new SqlConnection("Data Source=GORKEM;Initial Catalog=PersonalDatabase;Integrated Security=True");
            connection_update.Open();
            SqlCommand command_update = new SqlCommand("Update PersonalDatabase Set PerName=@pu1,PerSurname=@pu2,PerCity=@pu3,PerSalary=@pu4,PerStatus=@pu5,PerJob=@pu6 where PerId=@pu7",connection_update);
            command_update.Parameters.AddWithValue("@pu1",txt2Name.Text);
            command_update.Parameters.AddWithValue("@pu2", txt2Surname.Text);
            command_update.Parameters.AddWithValue("@pu6", txt2Job.Text);
            command_update.Parameters.AddWithValue("@pu5", status_update);
            command_update.Parameters.AddWithValue("@pu4", Convert.ToInt16(txt2Salary.Text));
            command_update.Parameters.AddWithValue("@pu3", txt2City.Text);
            command_update.Parameters.AddWithValue("@pu7", param_id);
            command_update.ExecuteNonQuery();
            connection_update.Close();
            MessageBox.Show("Row successfully updated");
            this.Close();
        }

        private void rdb2Married_CheckedChanged(object sender, EventArgs e)
        {
            status_update = true;
        }

        private void rdb2Single_CheckedChanged(object sender, EventArgs e)
        {
            status_update = false;
        }
    }
}
