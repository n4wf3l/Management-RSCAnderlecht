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
    public partial class ChangeTrainer : Form
    {
        public static string setValueTrainer;
        SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ajari\\OneDrive\\Documenten\\CurrentTrainerOfAnd.mdf;Integrated Security=True;Connect Timeout=30");

        public ChangeTrainer()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            CurrentTrainerOfAndDataContext ctl = new CurrentTrainerOfAndDataContext();
            var selectQuery = from a in ctl.GetTable<CurrentTrainerOfAnd>()
                              select a;
            dataGridView1.DataSource = selectQuery;

        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBoxTrainer.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void ChangeTrainer_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTrainer.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Gelieve alle vakken in te vullen");
            }
            else {           
            CurrentTrainerOfAndDataContext db = new CurrentTrainerOfAndDataContext();
            CurrentTrainerOfAnd cta = db.CurrentTrainerOfAnds.FirstOrDefault(cta1 => cta1.Id.Equals(textBox1.Text));
            cta.name = textBoxTrainer.Text;
            cta.age = double.Parse(textBox3.Text);
            cta.exclub = textBox4.Text;
            db.SubmitChanges();
            MessageBox.Show("Trainer geüpdate. Gelieve het beheerpagina te refreshen.");
            UpdateGrid();
                //Data meenemen naar vorige Form
                setValueTrainer = textBoxTrainer.Text;
                // Close
                this.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTrainer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }
    }
}
