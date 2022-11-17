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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            add_UControls(new UserControl_Home());
            panel2_home.BackColor = Color.BlueViolet;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach(var pnl in tableLayoutPanel1.Controls.OfType<Panel>())

                pnl.BackColor = Color.Silver;

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "Btn_Home":
                    add_UControls(new UserControl_Home());
                    panel2_home.BackColor = Color.BlueViolet;
                    break;
                case "Btn_About":
                    add_UControls(new UserControl_About());
                    panel2_about.BackColor = Color.BlueViolet;
                    break;
                case "Btn_Help":
                    add_UControls(new UserControl_Help());
                    panel3_help.BackColor = Color.BlueViolet;
                    break;
                case "Btn_Parternship":
                    add_UControls(new UserControl_Parternship());
                    panel4_parternship.BackColor = Color.BlueViolet;
                    break;
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
