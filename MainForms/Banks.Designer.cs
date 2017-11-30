namespace ChequeRecord.MainForms
{
    partial class Banks
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBankDB = new System.Windows.Forms.ListBox();
            this.btnRemoveBank = new System.Windows.Forms.Button();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.txtBanks = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMyRemove = new System.Windows.Forms.Button();
            this.btnMyAdd = new System.Windows.Forms.Button();
            this.txtMybBranch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbBanks = new System.Windows.Forms.ComboBox();
            this.txtMybNo = new System.Windows.Forms.TextBox();
            this.txtMybName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsdMyBanks = new System.Windows.Forms.ListBox();
            this.btnMyClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBankDB);
            this.groupBox2.Controls.Add(this.btnRemoveBank);
            this.groupBox2.Controls.Add(this.btnAddBank);
            this.groupBox2.Controls.Add(this.txtBanks);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(585, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Banks";
            // 
            // lstBankDB
            // 
            this.lstBankDB.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBankDB.FormattingEnabled = true;
            this.lstBankDB.ItemHeight = 16;
            this.lstBankDB.Location = new System.Drawing.Point(8, 24);
            this.lstBankDB.Name = "lstBankDB";
            this.lstBankDB.Size = new System.Drawing.Size(80, 180);
            this.lstBankDB.TabIndex = 8;
            this.lstBankDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // btnRemoveBank
            // 
            this.btnRemoveBank.Enabled = false;
            this.btnRemoveBank.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveBank.Location = new System.Drawing.Point(94, 161);
            this.btnRemoveBank.Name = "btnRemoveBank";
            this.btnRemoveBank.Size = new System.Drawing.Size(110, 42);
            this.btnRemoveBank.TabIndex = 11;
            this.btnRemoveBank.Text = "Remove";
            this.btnRemoveBank.UseVisualStyleBackColor = true;
            this.btnRemoveBank.Click += new System.EventHandler(this.btnRemoveBank_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(94, 90);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(110, 42);
            this.btnAddBank.TabIndex = 10;
            this.btnAddBank.Text = "Add";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // txtBanks
            // 
            this.txtBanks.BackColor = System.Drawing.SystemColors.Window;
            this.txtBanks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBanks.Location = new System.Drawing.Point(94, 39);
            this.txtBanks.MaxLength = 4;
            this.txtBanks.Name = "txtBanks";
            this.txtBanks.Size = new System.Drawing.Size(110, 24);
            this.txtBanks.TabIndex = 9;
            this.txtBanks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBanks_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMyClear);
            this.groupBox1.Controls.Add(this.btnMyRemove);
            this.groupBox1.Controls.Add(this.btnMyAdd);
            this.groupBox1.Controls.Add(this.txtMybBranch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.cmbBanks);
            this.groupBox1.Controls.Add(this.txtMybNo);
            this.groupBox1.Controls.Add(this.txtMybName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lsdMyBanks);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Banks";
            // 
            // btnMyRemove
            // 
            this.btnMyRemove.Enabled = false;
            this.btnMyRemove.ForeColor = System.Drawing.Color.Red;
            this.btnMyRemove.Location = new System.Drawing.Point(485, 165);
            this.btnMyRemove.Name = "btnMyRemove";
            this.btnMyRemove.Size = new System.Drawing.Size(77, 42);
            this.btnMyRemove.TabIndex = 7;
            this.btnMyRemove.Text = "Remove";
            this.btnMyRemove.UseVisualStyleBackColor = true;
            this.btnMyRemove.Click += new System.EventHandler(this.btnMyRemove_Click);
            // 
            // btnMyAdd
            // 
            this.btnMyAdd.Location = new System.Drawing.Point(229, 165);
            this.btnMyAdd.Name = "btnMyAdd";
            this.btnMyAdd.Size = new System.Drawing.Size(77, 42);
            this.btnMyAdd.TabIndex = 6;
            this.btnMyAdd.Text = "Add";
            this.btnMyAdd.UseVisualStyleBackColor = true;
            this.btnMyAdd.Click += new System.EventHandler(this.btnMyAdd_Click);
            // 
            // txtMybBranch
            // 
            this.txtMybBranch.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybBranch.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybBranch.Location = new System.Drawing.Point(229, 128);
            this.txtMybBranch.MaxLength = 12;
            this.txtMybBranch.Name = "txtMybBranch";
            this.txtMybBranch.Size = new System.Drawing.Size(150, 24);
            this.txtMybBranch.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Branch";
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbType.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "CURRENT",
            "SAVINGS"});
            this.cmbType.Location = new System.Drawing.Point(434, 128);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(128, 24);
            this.cmbType.TabIndex = 5;
            // 
            // cmbBanks
            // 
            this.cmbBanks.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.Location = new System.Drawing.Point(434, 84);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(128, 24);
            this.cmbBanks.TabIndex = 3;
            // 
            // txtMybNo
            // 
            this.txtMybNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybNo.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybNo.Location = new System.Drawing.Point(229, 84);
            this.txtMybNo.MaxLength = 12;
            this.txtMybNo.Name = "txtMybNo";
            this.txtMybNo.Size = new System.Drawing.Size(150, 24);
            this.txtMybNo.TabIndex = 2;
            // 
            // txtMybName
            // 
            this.txtMybName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybName.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybName.Location = new System.Drawing.Point(229, 42);
            this.txtMybName.MaxLength = 30;
            this.txtMybName.Name = "txtMybName";
            this.txtMybName.Size = new System.Drawing.Size(333, 24);
            this.txtMybName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "A/C No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // lsdMyBanks
            // 
            this.lsdMyBanks.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsdMyBanks.FormattingEnabled = true;
            this.lsdMyBanks.ItemHeight = 16;
            this.lsdMyBanks.Location = new System.Drawing.Point(9, 24);
            this.lsdMyBanks.Name = "lsdMyBanks";
            this.lsdMyBanks.Size = new System.Drawing.Size(144, 180);
            this.lsdMyBanks.TabIndex = 0;
            this.lsdMyBanks.Click += new System.EventHandler(this.lsdMyBanks_Click);
            // 
            // btnMyClear
            // 
            this.btnMyClear.Location = new System.Drawing.Point(357, 165);
            this.btnMyClear.Name = "btnMyClear";
            this.btnMyClear.Size = new System.Drawing.Size(77, 42);
            this.btnMyClear.TabIndex = 15;
            this.btnMyClear.Text = "Clear";
            this.btnMyClear.UseVisualStyleBackColor = true;
            this.btnMyClear.Click += new System.EventHandler(this.btnMyClear_Click);
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 219);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Banks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks";
            this.Load += new System.EventHandler(this.Banks_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveBank;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.TextBox txtBanks;
        private System.Windows.Forms.ListBox lstBankDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBanks;
        private System.Windows.Forms.TextBox txtMybNo;
        private System.Windows.Forms.TextBox txtMybName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsdMyBanks;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtMybBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMyRemove;
        private System.Windows.Forms.Button btnMyAdd;
        private System.Windows.Forms.Button btnMyClear;
    }
}