namespace ChequeRecord.MainForms
{
    partial class Customers
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
            this.btnRemoveBank = new System.Windows.Forms.Button();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCusId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveBank
            // 
            this.btnRemoveBank.Enabled = false;
            this.btnRemoveBank.Font = new System.Drawing.Font("Kalam", 10F);
            this.btnRemoveBank.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveBank.Location = new System.Drawing.Point(337, 130);
            this.btnRemoveBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveBank.Name = "btnRemoveBank";
            this.btnRemoveBank.Size = new System.Drawing.Size(87, 36);
            this.btnRemoveBank.TabIndex = 11;
            this.btnRemoveBank.Text = "Remove";
            this.btnRemoveBank.UseVisualStyleBackColor = true;
            // 
            // btnAddBank
            // 
            this.btnAddBank.Font = new System.Drawing.Font("Kalam", 10F);
            this.btnAddBank.Location = new System.Drawing.Point(229, 130);
            this.btnAddBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(87, 36);
            this.btnAddBank.TabIndex = 10;
            this.btnAddBank.Text = "Add";
            this.btnAddBank.UseVisualStyleBackColor = true;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustName.Font = new System.Drawing.Font("Kalam", 11F);
            this.txtCustName.Location = new System.Drawing.Point(229, 76);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustName.MaxLength = 4;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(195, 31);
            this.txtCustName.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Kalam", 9F);
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MaxLength = 4;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 27);
            this.txtSearch.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChequeRecord.Properties.Resources.icon_search;
            this.pictureBox1.InitialImage = global::ChequeRecord.Properties.Resources.icon_search;
            this.pictureBox1.Location = new System.Drawing.Point(197, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 35);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(220, 150);
            this.dgvCustomers.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kalam", 10F);
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // lblCusId
            // 
            this.lblCusId.AutoSize = true;
            this.lblCusId.Font = new System.Drawing.Font("Kalam", 10F);
            this.lblCusId.Location = new System.Drawing.Point(266, 35);
            this.lblCusId.Name = "lblCusId";
            this.lblCusId.Size = new System.Drawing.Size(21, 22);
            this.lblCusId.TabIndex = 16;
            this.lblCusId.Text = "Id";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 188);
            this.Controls.Add(this.lblCusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRemoveBank);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.txtCustName);
            this.Font = new System.Drawing.Font("Kalam", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveBank;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCusId;
    }
}