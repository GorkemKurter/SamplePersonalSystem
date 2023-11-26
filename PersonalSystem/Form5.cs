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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int return_control = 0;
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=GORKEM;Initial Catalog=PersonalDatabase;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("Select Count(*) from PersonalAdministrator where Username=@id and Password=@pass", connection);
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return_control = Convert.ToInt16(reader[0]);


                }
                if (return_control == 1)
                {
                    MessageBox.Show("Welcome to the administration system");
                    Form1 frm = new Form1();
                    return_control = 0;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    frm.Show();
                    connection.Close();
                    reader.Close();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid username or password.Please try again.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return_control = 0;
                }
            }
            else
            {
                MessageBox.Show("Username and Password can not be empty!");

            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

