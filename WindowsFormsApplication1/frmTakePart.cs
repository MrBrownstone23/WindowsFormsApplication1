using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DBContext;
using WindowsFormsApplication1.EFModels;

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

        private void button1_Click(object sender, EventArgs e)
        {
            var quickID = int.Parse(textBox1.Text);
            

            using (var context = new InventoryContext())
            {
                var part = context.Part.Where(x => x.QuickID == quickID).FirstOrDefault();
                

                PartList.Add(part);

                var grid = PartList.Select(x => new
                {
                    QuickID = x.QuickID,
                    PartNumber = x.PartNumber,
                    SerialNumber = x.SerialNumber,
                    Description = x.Description,
                    Location = x.Location,
                    Category = x.Category,
                    Quantity = 1
                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = grid;
            }
        }

        public List<Part> PartList = new List<Part>();


    }
}
