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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayersGenerator2
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\AllPlayers.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("insert into StaffOfAnd values (@Id,@name,@age,@function)", con1);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            con1.Close();

            if (textBox2.Text == String.Empty || comboBox1.Text == String.Empty || textBox1.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show("Gelieve alle vakjes in te vullen");

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\AllPlayers.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StaffOfAnd values (@Id,@name,@age,@function)", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@function", comboBox1.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully saved");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty || comboBox1.Text == String.Empty || textBox1.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show("Gelieve alle vakjes in te vullen.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\AllPlayers.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update StaffOfAnd set name=@name, age= @age, function=@function where Id = @Id", con);

                cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@function", comboBox1.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully updated");
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\AllPlayers.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StaffOfAnd", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
            {
            int tel = dataGridView1.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["Id"].Value).Count(x => x != null);
            if (textBox1.Text == String.Empty)
                {
                    MessageBox.Show("Gelieve het id in te geven.");
                }
           
            else if (tel == 0)
            {
                MessageBox.Show("Deze personeel bestaat niet in ons systeem.");
            }
            else
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\AllPlayers.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete StaffOfAnd where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted");
                    this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }

        }
    }
}
