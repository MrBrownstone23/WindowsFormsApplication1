namespace WindowsFormsApplication1
{
    partial class frmTakePart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakePart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTakeInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinueTake = new System.Windows.Forms.Button();
            this.btnCancelTake = new System.Windows.Forms.Button();
            this.lblConfirmInfo = new System.Windows.Forms.Label();
            this.cboTechName = new System.Windows.Forms.ComboBox();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.tboDestination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTakeInfo
            // 
            this.lblTakeInfo.AutoSize = true;
            this.lblTakeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTakeInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeInfo.Location = new System.Drawing.Point(36, 181);
            this.lblTakeInfo.Name = "lblTakeInfo";
            this.lblTakeInfo.Size = new System.Drawing.Size(869, 32);
            this.lblTakeInfo.TabIndex = 1;
            this.lblTakeInfo.Text = "Scan your part(s) and verify the correct part(s) in the table below.";
            this.lblTakeInfo.Click += new System.EventHandler(this.lblTakeInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(322, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 210);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnContinueTake
            // 
            this.btnContinueTake.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnContinueTake.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueTake.Location = new System.Drawing.Point(737, 543);
            this.btnContinueTake.Name = "btnContinueTake";
            this.btnContinueTake.Size = new System.Drawing.Size(185, 62);
            this.btnContinueTake.TabIndex = 3;
            this.btnContinueTake.Text = "Continue";
            this.btnContinueTake.UseVisualStyleBackColor = false;
            // 
            // btnCancelTake
            // 
            this.btnCancelTake.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelTake.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTake.Location = new System.Drawing.Point(27, 543);
            this.btnCancelTake.Name = "btnCancelTake";
            this.btnCancelTake.Size = new System.Drawing.Size(185, 62);
            this.btnCancelTake.TabIndex = 4;
            this.btnCancelTake.Text = "Cancel / Void";
            this.btnCancelTake.UseVisualStyleBackColor = false;
            // 
            // lblConfirmInfo
            // 
            this.lblConfirmInfo.AutoSize = true;
            this.lblConfirmInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmInfo.Location = new System.Drawing.Point(163, 272);
            this.lblConfirmInfo.Name = "lblConfirmInfo";
            this.lblConfirmInfo.Size = new System.Drawing.Size(617, 19);
            this.lblConfirmInfo.TabIndex = 5;
            this.lblConfirmInfo.Text = "Click \"Continue\" to Finalize the Transaction, or \"Cancel\" to Void the transaction" +
    ".";
            // 
            // cboTechName
            // 
            this.cboTechName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTechName.FormattingEnabled = true;
            this.cboTechName.Location = new System.Drawing.Point(327, 215);
            this.cboTechName.Name = "cboTechName";
            this.cboTechName.Size = new System.Drawing.Size(255, 24);
            this.cboTechName.TabIndex = 6;
            this.cboTechName.Text = "Select Your Name";
            // 
            // cboReason
            // 
            this.cboReason.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Location = new System.Drawing.Point(327, 245);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(255, 24);
            this.cboReason.TabIndex = 7;
            this.cboReason.Text = "Reason for taking part?";
            // 
            // tboDestination
            // 
            this.tboDestination.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboDestination.Location = new System.Drawing.Point(601, 231);
            this.tboDestination.Name = "tboDestination";
            this.tboDestination.Size = new System.Drawing.Size(240, 22);
            this.tboDestination.TabIndex = 8;
            this.tboDestination.Text = "Where is it going? (Please Type)";
            this.tboDestination.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmTakePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.tboDestination);
            this.Controls.Add(this.cboReason);
            this.Controls.Add(this.lblTakeInfo);
            this.Controls.Add(this.cboTechName);
            this.Controls.Add(this.lblConfirmInfo);
            this.Controls.Add(this.btnCancelTake);
            this.Controls.Add(this.btnContinueTake);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTakePart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taking Part(s) from Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTakeInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinueTake;
        private System.Windows.Forms.Button btnCancelTake;
        private System.Windows.Forms.Label lblConfirmInfo;
        private System.Windows.Forms.ComboBox cboTechName;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.TextBox tboDestination;
    }
}