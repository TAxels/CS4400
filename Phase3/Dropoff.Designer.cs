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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblDatetime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 279);
            this.dataGridView1.TabIndex = 0;
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
            // Dropoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDatetime);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dropoff";
            this.Size = new System.Drawing.Size(529, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblDatetime;
    }
}
