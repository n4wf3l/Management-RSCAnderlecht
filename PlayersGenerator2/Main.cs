using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayersGenerator2
{
    public partial class Main : Form
    {

    //Bewegende Form
        int mov;
        int movX;
        int movY;
        public Main()
        {
            InitializeComponent();
        }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "AllPlayers-Nawfel-AJR-2.mdf"));

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Bewegende Form via bovenste panel
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
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
                    panel2_manage.BackColor = Color.BlueViolet;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1Window = new Form1();
            form1Window.Show();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1){
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }

}
