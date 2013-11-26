﻿namespace PresentationTier
{
    partial class Pickups
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientData = new System.Windows.Forms.DataGridView();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
            this.SuspendLayout();
            // 
            // clientData
            // 
            this.clientData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.last,
            this.first,
            this.size,
            this.address,
            this.telephone,
            this.day});
            this.clientData.Location = new System.Drawing.Point(0, 0);
            this.clientData.MultiSelect = false;
            this.clientData.Name = "clientData";
            this.clientData.ReadOnly = true;
            this.clientData.RowTemplate.Height = 24;
            this.clientData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientData.Size = new System.Drawing.Size(742, 242);
            this.clientData.TabIndex = 0;
            // 
            // last
            // 
            this.last.HeaderText = "Last Name";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // first
            // 
            this.first.HeaderText = "First Name";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // day
            // 
            this.day.HeaderText = "Monthly Pickup Day";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSignIn.Location = new System.Drawing.Point(334, 256);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(78, 27);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReturn.Location = new System.Drawing.Point(293, 291);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(158, 27);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to Home Page";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Pickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.clientData);
            this.Name = "Pickups";
            this.Size = new System.Drawing.Size(745, 331);
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientData;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnReturn;
    }
}
