namespace PlayersGenerator2
{
    partial class UserControl_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HomePagina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "View ListPlayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePagina
            // 
            this.HomePagina.AutoSize = true;
            this.HomePagina.Location = new System.Drawing.Point(391, 139);
            this.HomePagina.Name = "HomePagina";
            this.HomePagina.Size = new System.Drawing.Size(67, 13);
            this.HomePagina.TabIndex = 5;
            this.HomePagina.Text = "Homepagina";
            // 
            // UserControl_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.HomePagina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HomePagina;
    }
}
