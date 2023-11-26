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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=GORKEM;Initial Catalog=PersonalDatabase;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select Avg(PerSalary),PerCity from PersonalDatabase group by PerCity",connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {   

                chart1.Series["Salary-City"].Points.AddXY(reader[1], reader[0]);
            
            }
            reader.Close();

            SqlCommand command_secgraph = new SqlCommand("Select PerCity,Count(*) from PersonalDatabase group by PerCity", connection);
            SqlDataReader reader_secgraph = command_secgraph.ExecuteReader();

            while (reader_secgraph.Read())
            {

                chart2.Series["Job-City"].Points.AddXY(reader_secgraph[0], reader_secgraph[1]);
         
            }
            reader_secgraph.Close();
            connection.Close();
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
