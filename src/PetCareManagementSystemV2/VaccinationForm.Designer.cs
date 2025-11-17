namespace PetCareManagementSystemV2
{
    partial class VaccinationForm
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
            dtGivenDate = new DateTimePicker();
            cmbPet = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnLoadAll = new Button();
            dgvVaccs = new DataGridView();
            label7 = new Label();
            txtVaccId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtVaccineName = new TextBox();
            dtNextDue = new DateTimePicker();
            txtNotes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVaccs).BeginInit();
            SuspendLayout();
            // 
            // dtGivenDate
            // 
            dtGivenDate.Location = new Point(291, 190);
            dtGivenDate.Name = "dtGivenDate";
            dtGivenDate.Size = new Size(193, 27);
            dtGivenDate.TabIndex = 56;
            // 
            // cmbPet
            // 
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(291, 67);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(193, 28);
            cmbPet.TabIndex = 55;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(561, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 29);
            btnClear.TabIndex = 54;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 29);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(561, 66);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(116, 29);
            btnLoadAll.TabIndex = 50;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // dgvVaccs
            // 
            dgvVaccs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaccs.Location = new Point(61, 371);
            dgvVaccs.Name = "dgvVaccs";
            dgvVaccs.RowHeadersWidth = 51;
            dgvVaccs.Size = new Size(684, 167);
            dgvVaccs.TabIndex = 49;
            dgvVaccs.CellClick += dgvVaccs_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(123, 332);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 48;
            label7.Text = "DataGridView";
            // 
            // txtVaccId
            // 
            txtVaccId.Location = new Point(291, 111);
            txtVaccId.Name = "txtVaccId";
            txtVaccId.ReadOnly = true;
            txtVaccId.Size = new Size(193, 27);
            txtVaccId.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 231);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 46;
            label6.Text = "NextDueDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 193);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 45;
            label5.Text = "GivenDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 281);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 44;
            label4.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 68);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 43;
            label3.Text = "PetId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 115);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 42;
            label2.Text = "VaccinationId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 17);
            label1.Name = "label1";
            label1.Size = new Size(179, 27);
            label1.TabIndex = 41;
            label1.Text = "Vaccination Form";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(123, 154);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 59;
            label8.Text = "VaccineName";
            // 
            // txtVaccineName
            // 
            txtVaccineName.Location = new Point(291, 150);
            txtVaccineName.Name = "txtVaccineName";
            txtVaccineName.Size = new Size(193, 27);
            txtVaccineName.TabIndex = 60;
            // 
            // dtNextDue
            // 
            dtNextDue.Location = new Point(291, 228);
            dtNextDue.Name = "dtNextDue";
            dtNextDue.ShowCheckBox = true;
            dtNextDue.Size = new Size(193, 27);
            dtNextDue.TabIndex = 61;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(291, 280);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(193, 59);
            txtNotes.TabIndex = 62;
            // 
            // VaccinationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(txtNotes);
            Controls.Add(dtNextDue);
            Controls.Add(txtVaccineName);
            Controls.Add(label8);
            Controls.Add(dtGivenDate);
            Controls.Add(cmbPet);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadAll);
            Controls.Add(dgvVaccs);
            Controls.Add(label7);
            Controls.Add(txtVaccId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VaccinationForm";
            Text = "VaccinationForm";
            Load += VaccinationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVaccs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtGivenDate;
        private ComboBox cmbPet;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnLoadAll;
        private DataGridView dgvVaccs;
        private Label label7;
        private TextBox txtVaccId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox txtVaccineName;
        private DateTimePicker dtNextDue;
        private TextBox txtNotes;
    }
}