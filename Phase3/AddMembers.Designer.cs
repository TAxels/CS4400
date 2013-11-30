namespace Phase3
{
    partial class AddMembers
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
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMembers
            // 
            this.dgMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first,
            this.last,
            this.gender,
            this.dob});
            this.dgMembers.Location = new System.Drawing.Point(3, 3);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.RowTemplate.Height = 24;
            this.dgMembers.Size = new System.Drawing.Size(460, 331);
            this.dgMembers.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(155, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Family Members";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.HeaderText = "First Name";
            this.first.Name = "first";
            // 
            // last
            // 
            this.last.HeaderText = "Last Name";
            this.last.Name = "last";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            // 
            // AddMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgMembers);
            this.Name = "AddMembers";
            this.Size = new System.Drawing.Size(466, 396);
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}
