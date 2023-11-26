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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExitStatistics_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }
        SqlConnection connection = new SqlConnection("Data Source=GORKEM;Initial Catalog=PersonalDatabase;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
           
            connection.Open();
            SqlCommand command = new SqlCommand("Select Count (*) from PersonalDatabase",connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                label7.Text = reader[0].ToString();
            }
            reader.Close();
            SqlCommand command_status = new SqlCommand("Select Count (*) from PersonalDatabase where PerStatus=@ps1",connection);
            command_status.Parameters.AddWithValue("@ps1", true);
            reader= command_status.ExecuteReader();
            while(reader.Read())
            {
            
                label8.Text = reader[0].ToString();
            
            }
            reader.Close();
            SqlCommand command_not_status = new SqlCommand("Select Count (*) from PersonalDatabase where PerStatus=@ps1not",connection);
            command_not_status.Parameters.AddWithValue("@ps1not", false);
            reader= command_not_status.ExecuteReader();
            while (reader.Read())
            {
                label9.Text= reader[0].ToString();
            
            }
            reader.Close();
            SqlCommand command_avg_salary = new SqlCommand("Select AVG(PerSalary) from PersonalDatabase", connection);
            reader = command_avg_salary.ExecuteReader();
            while (reader.Read())
            {
                label10.Text = reader[0].ToString();
            }
            reader.Close();
            SqlCommand command_sum_salary = new SqlCommand("Select SUM(PerSalary) from PersonalDatabase", connection);
            reader = command_sum_salary.ExecuteReader();
            while (reader.Read())
            {
                label11.Text = reader[0].ToString();

            }
            reader.Close();
            SqlCommand command_distinct_cities = new SqlCommand("Select distinct(PerCity) from PersonalDatabase", connection);
            reader = command_distinct_cities.ExecuteReader();
            int city_counter = 0;
            while (reader.Read())
            {

                city_counter++;
            
            }
            reader.Close();
            label13.Text = city_counter.ToString();
            connection.Close();
        }
    }
}
