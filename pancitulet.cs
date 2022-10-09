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
    public partial class pancitulet : Form
    {

        public string Date,SName,Age,Gender,BorrowersID,email,description,book,quantity,db,dr;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics jabol = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, jabol);
            Graphics habol = Graphics.FromImage(bmp);
            habol.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;



        public Image img = null;
        public Image bookimage = null;

        public pancitulet()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }
        private void print(Panel pnl)
        {
           
        }

        private void pancitulet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Print");
        }

        private void panelprint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pancitulet_Load(object sender, EventArgs e)
        {
            labeldate.Text = Date;
            Email1.Text = email;
            lblName1.Text = SName;
            lblage1.Text = Age;
            lblgender1.Text = Gender;
            ID1.Text = BorrowersID;
            photo.Image = img;
            pictureBox4.Image = bookimage;
            deskj.Text = description;
            Booker.Text = book;
            quando.Text = quantity;
            dbsorya.Text = db;
            drjones.Text = dr;


            
        }

    }
}
