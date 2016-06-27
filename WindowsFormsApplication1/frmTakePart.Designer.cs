﻿namespace WindowsFormsApplication1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTakeInfo
            // 
            this.lblTakeInfo.AutoSize = true;
            this.lblTakeInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeInfo.Location = new System.Drawing.Point(33, 222);
            this.lblTakeInfo.Name = "lblTakeInfo";
            this.lblTakeInfo.Size = new System.Drawing.Size(869, 32);
            this.lblTakeInfo.TabIndex = 1;
            this.lblTakeInfo.Text = "Scan your part(s) and verify the correct part(s) in the table below.";
            this.lblTakeInfo.Click += new System.EventHandler(this.lblTakeInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(322, -10);
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
            this.btnContinueTake.Text = "Continue / Take";
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
            // frmTakePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.btnCancelTake);
            this.Controls.Add(this.btnContinueTake);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTakeInfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTakePart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTakePart";
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
    }
}