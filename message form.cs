using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace WindowsFormsApplication2
{

    public partial class message_form : Form
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;




        public message_form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            login = new NetworkCredential(txtadmin.Text, txtpassword.Text);
            client = new SmtpClient(txtsmtp.Text);
            client.Port = Convert.ToInt32(txtport.Text);
            client.EnableSsl = chkssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtadmin.Text + txtsmtp.Text.Replace("smtp.", "@"), "ss3007499@gmail.com", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtto.Text));
            if (!string.IsNullOrEmpty(txtfrom.Text))
                msg.To.Add(new MailAddress(txtfrom.Text));
            msg.Subject = txtsubj.Text;
            msg.Body = txtmessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userstate = "sending....";
            client.SendAsync(msg, userstate);
            







        }
        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send  canceled.", e.UserState), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0}{1}", e.UserState, e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Message sent.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}






























