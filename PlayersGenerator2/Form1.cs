using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayersGenerator2
{
    public partial class Form1 : Form
    {
        // Bewegende form dankzij panel (bovenkant)

        int mov;
        int movX;
        int movY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bewegende Form via bovenste panel
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\loginForm.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty) 
            {
                MessageBox.Show("Gelieve alle vakjes in te vullen");

            }
            else
            {

                this.Hide();
                Loading loadingwindow = new Loading();
                loadingwindow.Show();


            }
        }


        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginTest logintest = new LoginTest();
            logintest.Show();
        }
    }
}
