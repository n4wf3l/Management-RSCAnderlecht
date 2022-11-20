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

namespace PlayersGenerator2
{
    public partial class LoginTest : Form
    {

        public LoginTest()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\LoginForm.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = textBox1.Text;
            user_password = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM LoginForm WHERE username = '"+textBox1.Text+"' AND password = '" +textBox2.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    user_password = textBox2.Text;

                    this.Hide();
                    Loading loadingwindow = new Loading();
                    loadingwindow.Show();                   
                }
          
            else
            {
                MessageBox.Show("Invalid login details");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
