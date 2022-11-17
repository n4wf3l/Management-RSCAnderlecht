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

    }
}
