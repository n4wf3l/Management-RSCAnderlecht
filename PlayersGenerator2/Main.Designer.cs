namespace PlayersGenerator2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4_parternship = new System.Windows.Forms.Panel();
            this.Btn_Parternship = new System.Windows.Forms.Button();
            this.panel3_help = new System.Windows.Forms.Panel();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.panel2_manage = new System.Windows.Forms.Panel();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.panel2_about = new System.Windows.Forms.Panel();
            this.Btn_About = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4_parternship.SuspendLayout();
            this.panel3_help.SuspendLayout();
            this.panel2_manage.SuspendLayout();
            this.panel2_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F);
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayersGenerator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage Player";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "View ListPlayer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(445, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Log out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel4_parternship, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3_help, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2_manage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2_about, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel4_parternship
            // 
            this.panel4_parternship.BackColor = System.Drawing.Color.Silver;
            this.panel4_parternship.Controls.Add(this.Btn_Parternship);
            this.panel4_parternship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4_parternship.Location = new System.Drawing.Point(605, 5);
            this.panel4_parternship.Margin = new System.Windows.Forms.Padding(5);
            this.panel4_parternship.Name = "panel4_parternship";
            this.panel4_parternship.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel4_parternship.Size = new System.Drawing.Size(190, 72);
            this.panel4_parternship.TabIndex = 3;
            // 
            // Btn_Parternship
            // 
            this.Btn_Parternship.BackColor = System.Drawing.Color.Silver;
            this.Btn_Parternship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Parternship.FlatAppearance.BorderSize = 0;
            this.Btn_Parternship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Parternship.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Parternship.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Parternship.Location = new System.Drawing.Point(0, 0);
            this.Btn_Parternship.Name = "Btn_Parternship";
            this.Btn_Parternship.Size = new System.Drawing.Size(190, 67);
            this.Btn_Parternship.TabIndex = 6;
            this.Btn_Parternship.Text = "Parternship";
            this.Btn_Parternship.UseVisualStyleBackColor = false;
            this.Btn_Parternship.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panel3_help
            // 
            this.panel3_help.BackColor = System.Drawing.Color.Silver;
            this.panel3_help.Controls.Add(this.Btn_Help);
            this.panel3_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_help.Location = new System.Drawing.Point(405, 5);
            this.panel3_help.Margin = new System.Windows.Forms.Padding(5);
            this.panel3_help.Name = "panel3_help";
            this.panel3_help.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel3_help.Size = new System.Drawing.Size(190, 72);
            this.panel3_help.TabIndex = 2;
            // 
            // Btn_Help
            // 
            this.Btn_Help.BackColor = System.Drawing.Color.Silver;
            this.Btn_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Help.FlatAppearance.BorderSize = 0;
            this.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Help.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Help.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Help.Location = new System.Drawing.Point(0, 0);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(190, 67);
            this.Btn_Help.TabIndex = 6;
            this.Btn_Help.Text = "Help";
            this.Btn_Help.UseVisualStyleBackColor = false;
            this.Btn_Help.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panel2_manage
            // 
            this.panel2_manage.BackColor = System.Drawing.Color.Silver;
            this.panel2_manage.Controls.Add(this.Btn_Home);
            this.panel2_manage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_manage.Location = new System.Drawing.Point(205, 5);
            this.panel2_manage.Margin = new System.Windows.Forms.Padding(5);
            this.panel2_manage.Name = "panel2_manage";
            this.panel2_manage.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2_manage.Size = new System.Drawing.Size(190, 72);
            this.panel2_manage.TabIndex = 1;
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.Silver;
            this.Btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Home.Location = new System.Drawing.Point(0, 0);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(190, 67);
            this.Btn_Home.TabIndex = 6;
            this.Btn_Home.Text = "Manage";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panel2_about
            // 
            this.panel2_about.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2_about.Controls.Add(this.Btn_About);
            this.panel2_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_about.Location = new System.Drawing.Point(5, 5);
            this.panel2_about.Margin = new System.Windows.Forms.Padding(5);
            this.panel2_about.Name = "panel2_about";
            this.panel2_about.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2_about.Size = new System.Drawing.Size(190, 72);
            this.panel2_about.TabIndex = 0;
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.Color.Silver;
            this.Btn_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_About.FlatAppearance.BorderSize = 0;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_About.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_About.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Btn_About.Location = new System.Drawing.Point(0, 0);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(190, 67);
            this.Btn_About.TabIndex = 6;
            this.Btn_About.Text = "About";
            this.Btn_About.UseVisualStyleBackColor = false;
            this.Btn_About.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 132);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 318);
            this.panel_main.TabIndex = 5;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayersGenerator2.Properties.Resources.anderlechtlogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::PlayersGenerator2.Properties.Resources.closewindowpng;
            this.BtnExit.Location = new System.Drawing.Point(784, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(16, 17);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExit.TabIndex = 1;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4_parternship.ResumeLayout(false);
            this.panel3_help.ResumeLayout(false);
            this.panel2_manage.ResumeLayout(false);
            this.panel2_about.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4_parternship;
        private System.Windows.Forms.Button Btn_Parternship;
        private System.Windows.Forms.Panel panel3_help;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.Panel panel2_manage;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Panel panel2_about;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button3;
    }
}