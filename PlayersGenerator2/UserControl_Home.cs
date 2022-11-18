using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayersGenerator2
{
    public partial class UserControl_Home : UserControl
    {
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void UserControl_Home_Load(object sender, EventArgs e)
        {
           textBox1.Text = ChangeTrainer.setValueTrainer;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayer addplayer = new AddPlayer();
            addplayer.ShowDialog();

            if (addplayer.DialogResult == DialogResult.OK)
            {
                addplayer.Dispose();
            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            AllPlayers allplayers = new AllPlayers();
            allplayers.ShowDialog();

            if (allplayers.DialogResult == DialogResult.OK)
            {
                allplayers.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.ShowDialog();

            if (addstaff.DialogResult == DialogResult.OK)
            {
                addstaff.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllStaffs allstaffs = new AllStaffs();
            allstaffs.ShowDialog();

            if (allstaffs.DialogResult == DialogResult.OK)
            {
                allstaffs.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTrainer changetrainer = new ChangeTrainer();
            changetrainer.ShowDialog();
 

            if (changetrainer.DialogResult == DialogResult.OK)
            {
                changetrainer.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
