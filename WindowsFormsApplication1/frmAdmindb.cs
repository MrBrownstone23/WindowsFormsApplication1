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
    public partial class frmAdmindb : Form
    {
        public frmAdmindb()
        {
            InitializeComponent();
        }

        private void frmAdmindb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WindowsFormsApplication1_DBContext_InventoryContextDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.Part);

        }
    }
}
