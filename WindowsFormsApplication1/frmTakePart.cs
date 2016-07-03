using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmTakePart : Form
    {
        public frmTakePart()
        {
            InitializeComponent();
        }

        private void lblTakeInfo_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTakePart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WindowsFormsApplication1_DBContext_InventoryContextDataSet.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.Tech);

        }
    }
}
