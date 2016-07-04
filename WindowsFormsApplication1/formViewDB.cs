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
    public partial class frmViewdb : Form
    {
        public frmViewdb()
        {
            InitializeComponent();
        }

        private void frmViewdb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WindowsFormsApplication1_DBContext_InventoryContextDataSet.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.Tech);
            HelperMethods.GetPartsGrid(dataGridView1);
            

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            cboTech.Visible = true;
            var techID = cboTech.SelectedValue.ToString();

            
        }

        private void cboTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            var techID = cboTech.SelectedValue.ToString();

            
        }
    }
}
