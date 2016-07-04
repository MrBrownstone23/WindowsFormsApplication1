namespace WindowsFormsApplication1
{
    partial class frmViewdb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSet();
            this.btnPartNumber = new System.Windows.Forms.Button();
            this.btnSerialNumber = new System.Windows.Forms.Button();
            this.btnIdNumber = new System.Windows.Forms.Button();
            this.btnEntireStock = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.partTableAdapter = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(31, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this._WindowsFormsApplication1_DBContext_InventoryContextDataSet;
            // 
            // _WindowsFormsApplication1_DBContext_InventoryContextDataSet
            // 
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.DataSetName = "_WindowsFormsApplication1_DBContext_InventoryContextDataSet";
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPartNumber
            // 
            this.btnPartNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPartNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPartNumber.Location = new System.Drawing.Point(31, 41);
            this.btnPartNumber.Name = "btnPartNumber";
            this.btnPartNumber.Size = new System.Drawing.Size(150, 51);
            this.btnPartNumber.TabIndex = 1;
            this.btnPartNumber.Text = "Part Number";
            this.btnPartNumber.UseVisualStyleBackColor = false;
            // 
            // btnSerialNumber
            // 
            this.btnSerialNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSerialNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSerialNumber.Location = new System.Drawing.Point(214, 41);
            this.btnSerialNumber.Name = "btnSerialNumber";
            this.btnSerialNumber.Size = new System.Drawing.Size(150, 51);
            this.btnSerialNumber.TabIndex = 2;
            this.btnSerialNumber.Text = "Serial Number";
            this.btnSerialNumber.UseVisualStyleBackColor = false;
            // 
            // btnIdNumber
            // 
            this.btnIdNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIdNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIdNumber.Location = new System.Drawing.Point(397, 41);
            this.btnIdNumber.Name = "btnIdNumber";
            this.btnIdNumber.Size = new System.Drawing.Size(150, 51);
            this.btnIdNumber.TabIndex = 3;
            this.btnIdNumber.Text = "ID Number";
            this.btnIdNumber.UseVisualStyleBackColor = false;
            // 
            // btnEntireStock
            // 
            this.btnEntireStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEntireStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntireStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntireStock.Location = new System.Drawing.Point(580, 41);
            this.btnEntireStock.Name = "btnEntireStock";
            this.btnEntireStock.Size = new System.Drawing.Size(150, 51);
            this.btnEntireStock.TabIndex = 4;
            this.btnEntireStock.Text = "Entire Stock";
            this.btnEntireStock.UseVisualStyleBackColor = false;
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTransactions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransactions.Location = new System.Drawing.Point(763, 41);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(150, 51);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Search";
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnEntireStock);
            this.Controls.Add(this.btnIdNumber);
            this.Controls.Add(this.btnSerialNumber);
            this.Controls.Add(this.btnPartNumber);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmViewdb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Viewer";
            this.Load += new System.EventHandler(this.frmViewdb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPartNumber;
        private System.Windows.Forms.Button btnSerialNumber;
        private System.Windows.Forms.Button btnIdNumber;
        private System.Windows.Forms.Button btnEntireStock;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.TextBox textBox1;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSet _WindowsFormsApplication1_DBContext_InventoryContextDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter partTableAdapter;
    }
}