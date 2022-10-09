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
    public partial class borw : Form
    {
        public borw()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void borw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qtyDataSet.qty' table. You can move, or remove it, as needed.
            this.qtyTableAdapter.Fill(this.qtyDataSet.qty);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
           qtyBindingSource.EndEdit();
                qtyTableAdapter.Update(this.qtyDataSet.qty);
                panel1.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qtyBindingSource.ResetBindings(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.qtyDataSet.qty.AddqtyRow(this.qtyDataSet.qty.NewqtyRow());
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qtyBindingSource.ResetBindings(false);
            }
        }
    }
}
