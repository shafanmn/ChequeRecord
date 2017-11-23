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
            this.btnMyAdd = new System.Windows.Forms.Button();
            this.btnMyRemove = new System.Windows.Forms.Button();
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
            this.groupBox2.Font = new System.Drawing.Font("Kalam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(610, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banks Database";
            // 
            // lstBankDB
            // 
            this.lstBankDB.Font = new System.Drawing.Font("Kalam", 11F);
            this.lstBankDB.FormattingEnabled = true;
            this.lstBankDB.ItemHeight = 24;
            this.lstBankDB.Location = new System.Drawing.Point(6, 32);
            this.lstBankDB.Name = "lstBankDB";
            this.lstBankDB.Size = new System.Drawing.Size(136, 148);
            this.lstBankDB.TabIndex = 8;
            this.lstBankDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // btnRemoveBank
            // 
            this.btnRemoveBank.Enabled = false;
            this.btnRemoveBank.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveBank.Location = new System.Drawing.Point(147, 151);
            this.btnRemoveBank.Name = "btnRemoveBank";
            this.btnRemoveBank.Size = new System.Drawing.Size(137, 34);
            this.btnRemoveBank.TabIndex = 11;
            this.btnRemoveBank.Text = "Remove";
            this.btnRemoveBank.UseVisualStyleBackColor = true;
            this.btnRemoveBank.Click += new System.EventHandler(this.btnRemoveBank_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(148, 90);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(137, 34);
            this.btnAddBank.TabIndex = 10;
            this.btnAddBank.Text = "Add";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // txtBanks
            // 
            this.txtBanks.BackColor = System.Drawing.SystemColors.Window;
            this.txtBanks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBanks.Font = new System.Drawing.Font("Kalam", 11F);
            this.txtBanks.Location = new System.Drawing.Point(147, 32);
            this.txtBanks.MaxLength = 4;
            this.txtBanks.Name = "txtBanks";
            this.txtBanks.Size = new System.Drawing.Size(138, 31);
            this.txtBanks.TabIndex = 9;
            this.txtBanks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBanks_KeyDown);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Kalam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Banks";
            // 
            // txtMybBranch
            // 
            this.txtMybBranch.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybBranch.Font = new System.Drawing.Font("Kalam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybBranch.Location = new System.Drawing.Point(240, 103);
            this.txtMybBranch.MaxLength = 12;
            this.txtMybBranch.Name = "txtMybBranch";
            this.txtMybBranch.Size = new System.Drawing.Size(164, 28);
            this.txtMybBranch.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Branch";
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbType.Font = new System.Drawing.Font("Kalam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "CURRENT",
            "SAVINGS"});
            this.cmbType.Location = new System.Drawing.Point(460, 103);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(126, 29);
            this.cmbType.TabIndex = 5;
            // 
            // cmbBanks
            // 
            this.cmbBanks.Font = new System.Drawing.Font("Kalam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.Location = new System.Drawing.Point(480, 64);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(106, 29);
            this.cmbBanks.TabIndex = 3;
            // 
            // txtMybNo
            // 
            this.txtMybNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybNo.Font = new System.Drawing.Font("Kalam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybNo.Location = new System.Drawing.Point(240, 68);
            this.txtMybNo.MaxLength = 12;
            this.txtMybNo.Name = "txtMybNo";
            this.txtMybNo.Size = new System.Drawing.Size(187, 28);
            this.txtMybNo.TabIndex = 2;
            // 
            // txtMybName
            // 
            this.txtMybName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMybName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMybName.Font = new System.Drawing.Font("Kalam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMybName.Location = new System.Drawing.Point(240, 33);
            this.txtMybName.MaxLength = 30;
            this.txtMybName.Name = "txtMybName";
            this.txtMybName.Size = new System.Drawing.Size(346, 28);
            this.txtMybName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "A/C No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // lsdMyBanks
            // 
            this.lsdMyBanks.Font = new System.Drawing.Font("Kalam", 11F);
            this.lsdMyBanks.FormattingEnabled = true;
            this.lsdMyBanks.ItemHeight = 24;
            this.lsdMyBanks.Location = new System.Drawing.Point(6, 30);
            this.lsdMyBanks.Name = "lsdMyBanks";
            this.lsdMyBanks.Size = new System.Drawing.Size(146, 148);
            this.lsdMyBanks.TabIndex = 0;
            // 
            // btnMyAdd
            // 
            this.btnMyAdd.Location = new System.Drawing.Point(240, 148);
            this.btnMyAdd.Name = "btnMyAdd";
            this.btnMyAdd.Size = new System.Drawing.Size(137, 34);
            this.btnMyAdd.TabIndex = 6;
            this.btnMyAdd.Text = "Add";
            this.btnMyAdd.UseVisualStyleBackColor = true;
            this.btnMyAdd.Click += new System.EventHandler(this.btnMyAdd_Click);
            // 
            // btnMyRemove
            // 
            this.btnMyRemove.Enabled = false;
            this.btnMyRemove.ForeColor = System.Drawing.Color.Red;
            this.btnMyRemove.Location = new System.Drawing.Point(449, 148);
            this.btnMyRemove.Name = "btnMyRemove";
            this.btnMyRemove.Size = new System.Drawing.Size(137, 34);
            this.btnMyRemove.TabIndex = 7;
            this.btnMyRemove.Text = "Remove";
            this.btnMyRemove.UseVisualStyleBackColor = true;
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
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
    }
}