namespace PlayersGenerator2
{
    partial class UserControl_Parternship
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
            this.Parternship = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parternship
            // 
            this.Parternship.AutoSize = true;
            this.Parternship.Location = new System.Drawing.Point(416, 176);
            this.Parternship.Name = "Parternship";
            this.Parternship.Size = new System.Drawing.Size(60, 13);
            this.Parternship.TabIndex = 0;
            this.Parternship.Text = "Parternship";
            // 
            // UserControl_Parternship
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Parternship);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Parternship";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Parternship;
    }
}
