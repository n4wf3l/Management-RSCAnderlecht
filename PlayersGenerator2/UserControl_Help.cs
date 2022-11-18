using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace PlayersGenerator2
{
    public partial class UserControl_Help : UserControl
    {
        public UserControl_Help()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "" || txtSubject.Text == "" || txtMessage.Text == "")
            {
                MessageBox.Show("Gelieve alle velden in te vullen.");
            }
            else
            {
                try
                {
                    SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
                    smtpClient.Port = 587;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    System.Net.NetworkCredential cd = new System.Net.NetworkCredential("nawfel.ajari@student.ehb.be", "nawnaw1030");
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = cd;
                    MailMessage mail = new MailMessage("nawfel.ajari@student.ehb.be", txtTo.Text);
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtMessage.Text;
                    smtpClient.Send(mail);
                    MessageBox.Show("Email is verzonden !");

                }
                catch (Exception)
                {
                    throw;

                }
            }
        }
    }
}
