namespace PresentationTier
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
            this.BagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPday = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
            this.SuspendLayout();
            // 
            // clientData
            // 
            this.clientData.AllowUserToAddRows = false;
            this.clientData.AllowUserToDeleteRows = false;
            this.clientData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.last,
            this.BagName,
            this.CID,
            this.first,
            this.size,
            this.address,
            this.telephone,
            this.day});
            this.clientData.Location = new System.Drawing.Point(0, 44);
            this.clientData.MultiSelect = false;
            this.clientData.Name = "clientData";
            this.clientData.ReadOnly = true;
            this.clientData.RowTemplate.Height = 24;
            this.clientData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientData.Size = new System.Drawing.Size(742, 240);
            this.clientData.TabIndex = 0;
            // 
            // last
            // 
            this.last.DataPropertyName = "LastName";
            this.last.HeaderText = "Last Name";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // BagName
            // 
            this.BagName.DataPropertyName = "Bag_Type";
            this.BagName.HeaderText = "Bag Name";
            this.BagName.Name = "BagName";
            this.BagName.ReadOnly = true;
            this.BagName.Visible = false;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "Client_ID";
            this.CID.HeaderText = "CID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            // 
            // first
            // 
            this.first.DataPropertyName = "FirstName";
            this.first.HeaderText = "First Name";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "Size";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "Phone";
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // day
            // 
            this.day.DataPropertyName = "PickUpDay";
            this.day.HeaderText = "Monthly Pickup Day";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSignIn.Location = new System.Drawing.Point(334, 298);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(78, 27);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReturn.Location = new System.Drawing.Point(293, 333);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(158, 27);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to Home Page";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pickup Day:";
            // 
            // cbPday
            // 
            this.cbPday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPday.FormattingEnabled = true;
            this.cbPday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbPday.Location = new System.Drawing.Point(381, 9);
            this.cbPday.Name = "cbPday";
            this.cbPday.Size = new System.Drawing.Size(72, 24);
            this.cbPday.TabIndex = 4;
            this.cbPday.SelectedIndexChanged += new System.EventHandler(this.cbPday_SelectedIndexChanged);
            // 
            // Pickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.cbPday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.clientData);
            this.Name = "Pickups";
            this.Size = new System.Drawing.Size(745, 373);
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientData;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPday;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn BagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
    }
}
