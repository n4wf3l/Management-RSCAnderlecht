namespace PlayersGenerator2
{
    partial class UserControl_About
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
            this.About = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Location = new System.Drawing.Point(367, 101);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(35, 13);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            // 
            // UserControl_About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.About);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_About";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label About;
    }
}
