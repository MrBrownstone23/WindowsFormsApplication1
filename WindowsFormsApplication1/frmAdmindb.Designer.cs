namespace WindowsFormsApplication1
{
    partial class frmAdmindb
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnEntireStock = new System.Windows.Forms.Button();
            this.btnIdNumber = new System.Windows.Forms.Button();
            this.btnSerialNumber = new System.Windows.Forms.Button();
            this.btnPartNumber = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(801, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Search";
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTransactions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransactions.Location = new System.Drawing.Point(786, 12);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(150, 51);
            this.btnTransactions.TabIndex = 12;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            // 
            // btnEntireStock
            // 
            this.btnEntireStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEntireStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntireStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntireStock.Location = new System.Drawing.Point(598, 12);
            this.btnEntireStock.Name = "btnEntireStock";
            this.btnEntireStock.Size = new System.Drawing.Size(150, 51);
            this.btnEntireStock.TabIndex = 11;
            this.btnEntireStock.Text = "Entire Stock";
            this.btnEntireStock.UseVisualStyleBackColor = false;
            // 
            // btnIdNumber
            // 
            this.btnIdNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIdNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIdNumber.Location = new System.Drawing.Point(410, 12);
            this.btnIdNumber.Name = "btnIdNumber";
            this.btnIdNumber.Size = new System.Drawing.Size(150, 51);
            this.btnIdNumber.TabIndex = 10;
            this.btnIdNumber.Text = "ID Number";
            this.btnIdNumber.UseVisualStyleBackColor = false;
            // 
            // btnSerialNumber
            // 
            this.btnSerialNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSerialNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSerialNumber.Location = new System.Drawing.Point(222, 12);
            this.btnSerialNumber.Name = "btnSerialNumber";
            this.btnSerialNumber.Size = new System.Drawing.Size(150, 51);
            this.btnSerialNumber.TabIndex = 9;
            this.btnSerialNumber.Text = "Serial Number";
            this.btnSerialNumber.UseVisualStyleBackColor = false;
            // 
            // btnPartNumber
            // 
            this.btnPartNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPartNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPartNumber.Location = new System.Drawing.Point(34, 12);
            this.btnPartNumber.Name = "btnPartNumber";
            this.btnPartNumber.Size = new System.Drawing.Size(150, 51);
            this.btnPartNumber.TabIndex = 8;
            this.btnPartNumber.Text = "Part Number";
            this.btnPartNumber.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 484);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(842, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 46);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "- Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(842, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 46);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(842, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmAdmindb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnEntireStock);
            this.Controls.Add(this.btnIdNumber);
            this.Controls.Add(this.btnSerialNumber);
            this.Controls.Add(this.btnPartNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAdmindb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Database Managment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnEntireStock;
        private System.Windows.Forms.Button btnIdNumber;
        private System.Windows.Forms.Button btnSerialNumber;
        private System.Windows.Forms.Button btnPartNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}