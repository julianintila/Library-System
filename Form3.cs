using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class japorm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public japorm()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            String color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Disablebutton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnltite.BackColor = color;
                }

            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnldesktop.Controls.Add(childForm);
            this.pnldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltite.Text = childForm.Text;


        }

        private void Disablebutton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dshforms.user2323232(), sender);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dshforms.bokung(), sender);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dshforms.transactions(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dshforms.DASHBOARD(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void japorm_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            lbldate.Text = DateTime.Now.ToLongDateString();

            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pnldesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntransactions_Click(object sender, EventArgs e)
        {
              OpenChildForm(new Dshforms.transactions2(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Close();
            
        }
    }
}
                    


        










       