namespace PresentationTier
{
    partial class FBag
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bagData = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bagData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(276, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(276, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bagData
            // 
            this.bagData.AllowUserToAddRows = false;
            this.bagData.AllowUserToDeleteRows = false;
            this.bagData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bagData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bagData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personName,
            this.BagName,
            this.Product,
            this.Quantity});
            this.bagData.Location = new System.Drawing.Point(3, 88);
            this.bagData.Name = "bagData";
            this.bagData.ReadOnly = true;
            this.bagData.RowTemplate.Height = 24;
            this.bagData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bagData.Size = new System.Drawing.Size(592, 256);
            this.bagData.TabIndex = 2;
            this.bagData.SelectionChanged += new System.EventHandler(this.bagData_SelectionChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.Location = new System.Drawing.Point(239, 356);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(121, 27);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Complete Pickup";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReturn.Location = new System.Drawing.Point(217, 392);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(165, 27);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Pickups Page";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // personName
            // 
            this.personName.DataPropertyName = "Name";
            this.personName.HeaderText = "PersonName";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            this.personName.Visible = false;
            // 
            // BagName
            // 
            this.BagName.DataPropertyName = "Bag_Name";
            this.BagName.HeaderText = "BagName";
            this.BagName.Name = "BagName";
            this.BagName.ReadOnly = true;
            this.BagName.Visible = false;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product_Name";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Current_Mnth_Qty";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // FBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.bagData);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Name = "FBag";
            this.Size = new System.Drawing.Size(598, 429);
            ((System.ComponentModel.ISupportInitialize)(this.bagData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView bagData;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
