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
    public partial class dashboard_na : Form
    {
        public dashboard_na()
        {
            InitializeComponent();
        }

        private void dashboard_na_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_UserDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.database_UserDataSet.USER);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void uSERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_UserDataSet);

        }
    }
}
