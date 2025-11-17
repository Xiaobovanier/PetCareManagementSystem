namespace PetCareManagementSystemV2
{
    partial class PetForm
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
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnLoadAll = new Button();
            dgvPets = new DataGridView();
            label7 = new Label();
            txtNotes = new TextBox();
            txtSpecies = new TextBox();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBreed = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cmbOwner = new ComboBox();
            dtBirthDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(561, 226);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 29);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 147);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 29);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(561, 61);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(116, 29);
            btnLoadAll.TabIndex = 32;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // dgvPets
            // 
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Location = new Point(67, 426);
            dgvPets.Name = "dgvPets";
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(675, 167);
            dgvPets.TabIndex = 31;
            dgvPets.CellClick += dgvPets_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(126, 387);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 30;
            label7.Text = "DataGridView";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(291, 319);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(193, 59);
            txtNotes.TabIndex = 29;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(291, 186);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(193, 27);
            txtSpecies.TabIndex = 28;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(291, 147);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(193, 27);
            txtPetName.TabIndex = 27;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(291, 63);
            txtPetId.Name = "txtPetId";
            txtPetId.ReadOnly = true;
            txtPetId.Size = new Size(193, 27);
            txtPetId.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 319);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 24;
            label6.Text = "Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 186);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 23;
            label5.Text = "Species";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 147);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 22;
            label4.Text = "PetName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 106);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 21;
            label3.Text = "OwnerId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 67);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 20;
            label2.Text = "PetId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 19;
            label1.Text = "Pet Form";
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(291, 228);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(193, 27);
            txtBreed.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(123, 228);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 37;
            label8.Text = "Breed";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(123, 272);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 39;
            label9.Text = "BirthDate";
            // 
            // cmbOwner
            // 
            cmbOwner.FormattingEnabled = true;
            cmbOwner.Location = new Point(291, 105);
            cmbOwner.Name = "cmbOwner";
            cmbOwner.Size = new Size(193, 28);
            cmbOwner.TabIndex = 41;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(291, 272);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(193, 27);
            dtBirthDate.TabIndex = 42;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(dtBirthDate);
            Controls.Add(cmbOwner);
            Controls.Add(label9);
            Controls.Add(txtBreed);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadAll);
            Controls.Add(dgvPets);
            Controls.Add(label7);
            Controls.Add(txtNotes);
            Controls.Add(txtSpecies);
            Controls.Add(txtPetName);
            Controls.Add(txtPetId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PetForm";
            Text = "PetForm";
            Load += PetForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnLoadAll;
        private DataGridView dgvPets;
        private Label label7;
        private TextBox txtNotes;
        private TextBox txtSpecies;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBreed;
        private Label label8;
        private Label label9;
        private ComboBox cmbOwner;
        private DateTimePicker dtBirthDate;
    }
}