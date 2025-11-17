namespace PetCareManagementSystemV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOwners = new Button();
            btnPets = new Button();
            btnAppointments = new Button();
            btnVaccinations = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuOwnerForm = new ToolStripMenuItem();
            menuPetForm = new ToolStripMenuItem();
            menuAppointmentForm = new ToolStripMenuItem();
            menuVaccinationForm = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 80);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 42;
            label1.Text = "Pet Care Management System";
            // 
            // btnOwners
            // 
            btnOwners.BackColor = SystemColors.GradientInactiveCaption;
            btnOwners.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOwners.Location = new Point(285, 152);
            btnOwners.Name = "btnOwners";
            btnOwners.Size = new Size(212, 53);
            btnOwners.TabIndex = 43;
            btnOwners.Text = "Owners";
            btnOwners.UseVisualStyleBackColor = false;
            btnOwners.Click += btnOwners_Click;
            // 
            // btnPets
            // 
            btnPets.BackColor = SystemColors.GradientInactiveCaption;
            btnPets.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPets.Location = new Point(285, 235);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(212, 53);
            btnPets.TabIndex = 44;
            btnPets.Text = "Pets";
            btnPets.UseVisualStyleBackColor = false;
            btnPets.Click += btnPets_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = SystemColors.GradientInactiveCaption;
            btnAppointments.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAppointments.Location = new Point(285, 323);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(212, 53);
            btnAppointments.TabIndex = 45;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnVaccinations
            // 
            btnVaccinations.BackColor = SystemColors.GradientInactiveCaption;
            btnVaccinations.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVaccinations.Location = new Point(285, 412);
            btnVaccinations.Name = "btnVaccinations";
            btnVaccinations.Size = new Size(212, 53);
            btnVaccinations.TabIndex = 46;
            btnVaccinations.Text = "Vaccinations";
            btnVaccinations.UseVisualStyleBackColor = false;
            btnVaccinations.Click += btnVaccinations_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 47;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOwnerForm, menuPetForm, menuAppointmentForm, menuVaccinationForm });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(65, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // menuOwnerForm
            // 
            menuOwnerForm.Name = "menuOwnerForm";
            menuOwnerForm.Size = new Size(232, 26);
            menuOwnerForm.Text = "Owner Form";
            menuOwnerForm.Click += menuOwnerForm_Click;
            // 
            // menuPetForm
            // 
            menuPetForm.Name = "menuPetForm";
            menuPetForm.Size = new Size(232, 26);
            menuPetForm.Text = "Pet Form";
            menuPetForm.Click += menuPetForm_Click;
            // 
            // menuAppointmentForm
            // 
            menuAppointmentForm.Name = "menuAppointmentForm";
            menuAppointmentForm.Size = new Size(232, 26);
            menuAppointmentForm.Text = "Appointment Form";
            menuAppointmentForm.Click += menuAppointmentForm_Click;
            // 
            // menuVaccinationForm
            // 
            menuVaccinationForm.Name = "menuVaccinationForm";
            menuVaccinationForm.Size = new Size(232, 26);
            menuVaccinationForm.Text = "Vaccinations Form";
            menuVaccinationForm.Click += menuVaccinationForm_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btnVaccinations);
            Controls.Add(btnAppointments);
            Controls.Add(btnPets);
            Controls.Add(btnOwners);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Pet Care Management System";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOwners;
        private Button btnPets;
        private Button btnAppointments;
        private Button btnVaccinations;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuOwnerForm;
        private ToolStripMenuItem menuPetForm;
        private ToolStripMenuItem menuAppointmentForm;
        private ToolStripMenuItem menuVaccinationForm;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
