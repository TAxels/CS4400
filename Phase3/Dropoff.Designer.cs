namespace Phase3
{
    partial class Dropoff
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
            this.dgDropoff = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDropoff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDropoff
            // 
            this.dgDropoff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDropoff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDropoff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDropoff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.source,
            this.quantity});
            this.dgDropoff.Location = new System.Drawing.Point(3, 54);
            this.dgDropoff.Name = "dgDropoff";
            this.dgDropoff.RowTemplate.Height = 24;
            this.dgDropoff.Size = new System.Drawing.Size(523, 279);
            this.dgDropoff.TabIndex = 0;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.Location = new System.Drawing.Point(198, 351);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(133, 28);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete Drop Off";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblDatetime
            // 
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Location = new System.Drawing.Point(241, 19);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(46, 17);
            this.lblDatetime.TabIndex = 2;
            this.lblDatetime.Text = "label1";
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            // 
            // source
            // 
            this.source.HeaderText = "Source";
            this.source.Name = "source";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // Dropoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDatetime);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dgDropoff);
            this.Name = "Dropoff";
            this.Size = new System.Drawing.Size(529, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dgDropoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDropoff;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}
