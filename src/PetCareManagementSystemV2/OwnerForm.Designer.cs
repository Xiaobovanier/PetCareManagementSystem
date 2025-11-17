namespace PetCareManagementSystemV2
{
    partial class OwnerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtOwnerId = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label7 = new Label();
            dgvOwners = new DataGridView();
            btnLoadAll = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOwners).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 0;
            label1.Text = "Owner Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 1;
            label2.Text = "OwnerId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 111);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "FullName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 152);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 191);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(136, 231);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // txtOwnerId
            // 
            txtOwnerId.Location = new Point(304, 68);
            txtOwnerId.Name = "txtOwnerId";
            txtOwnerId.ReadOnly = true;
            txtOwnerId.Size = new Size(193, 27);
            txtOwnerId.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(304, 111);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(193, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(304, 152);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(304, 231);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(193, 59);
            txtAddress.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(139, 313);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 11;
            label7.Text = "DataGridView";
            // 
            // dgvOwners
            // 
            dgvOwners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwners.Location = new Point(63, 352);
            dgvOwners.Name = "dgvOwners";
            dgvOwners.RowHeadersWidth = 51;
            dgvOwners.Size = new Size(688, 167);
            dgvOwners.TabIndex = 13;
            dgvOwners.CellClick += dgvOwners_CellClick;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(574, 66);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(116, 29);
            btnLoadAll.TabIndex = 14;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(574, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(574, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(574, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(574, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadAll);
            Controls.Add(dgvOwners);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtOwnerId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OwnerForm";
            Text = "OwnerForm";
            Load += OwnerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOwners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOwnerId;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label7;
        private DataGridView dgvOwners;
        private Button btnLoadAll;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}