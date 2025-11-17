namespace PetCareManagementSystemV2
{
    partial class AppointmentForm
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
            dgvAppts = new DataGridView();
            label7 = new Label();
            txtApptId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbPet = new ComboBox();
            dtApptTime = new DateTimePicker();
            cmbReason = new ComboBox();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAppts).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(561, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 29);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 154);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 29);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(561, 68);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(116, 29);
            btnLoadAll.TabIndex = 32;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // dgvAppts
            // 
            dgvAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppts.Location = new Point(70, 354);
            dgvAppts.Name = "dgvAppts";
            dgvAppts.RowHeadersWidth = 51;
            dgvAppts.Size = new Size(673, 181);
            dgvAppts.TabIndex = 31;
            dgvAppts.CellClick += dgvAppts_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(126, 315);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 30;
            label7.Text = "DataGridView";
            // 
            // txtApptId
            // 
            txtApptId.Location = new Point(291, 70);
            txtApptId.Name = "txtApptId";
            txtApptId.ReadOnly = true;
            txtApptId.Size = new Size(193, 27);
            txtApptId.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 233);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 24;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 193);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 23;
            label5.Text = "Reason";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 154);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 22;
            label4.Text = "ApptTime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 113);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 21;
            label3.Text = "PetId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 74);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 20;
            label2.Text = "AppointmentId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 19);
            label1.Name = "label1";
            label1.Size = new Size(195, 27);
            label1.TabIndex = 19;
            label1.Text = "Appointment Form";
            // 
            // cmbPet
            // 
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(291, 112);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(193, 28);
            cmbPet.TabIndex = 37;
            // 
            // dtApptTime
            // 
            dtApptTime.Location = new Point(291, 153);
            dtApptTime.Name = "dtApptTime";
            dtApptTime.Size = new Size(193, 27);
            dtApptTime.TabIndex = 38;
            // 
            // cmbReason
            // 
            cmbReason.FormattingEnabled = true;
            cmbReason.Location = new Point(291, 194);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(193, 28);
            cmbReason.TabIndex = 39;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(291, 234);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(193, 28);
            cmbStatus.TabIndex = 40;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(cmbStatus);
            Controls.Add(cmbReason);
            Controls.Add(dtApptTime);
            Controls.Add(cmbPet);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadAll);
            Controls.Add(dgvAppts);
            Controls.Add(label7);
            Controls.Add(txtApptId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnLoadAll;
        private DataGridView dgvAppts;
        private Label label7;
        private TextBox txtApptId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPet;
        private DateTimePicker dtApptTime;
        private ComboBox cmbReason;
        private ComboBox cmbStatus;
    }
}