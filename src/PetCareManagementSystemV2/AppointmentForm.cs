using PetCareManagementSystemV2.Models;
using PetCareManagementSystemV2.Repositories;

namespace PetCareManagementSystemV2
{
    public partial class AppointmentForm : Form
    {
        private readonly AppointmentRepository _apptRepo = new AppointmentRepository();
        private readonly PetRepository _petRepo = new PetRepository();

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadPets();
            LoadAppointments();
            LoadDropdowns();
        }

        private void LoadPets()
        {
            var pets = _petRepo.GetAll();
            cmbPet.DataSource = pets;
            cmbPet.DisplayMember = "PetName";
            cmbPet.ValueMember = "PetId";
        }

        private void LoadDropdowns()
        {
            // reason 
            cmbReason.Items.Clear();
            cmbReason.Items.AddRange(new string[]
            {
                "Regular Checkup",
                "Vaccination",
                "Surgery Consultation",
                "Dental Cleaning",
                "Skin Problem",
                "Emergency Visit"
            });

            // status 
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[]
            {
                "Scheduled",
                "Completed",
                "Cancelled"
            });
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadAppointments()
        {
            dgvAppts.DataSource = _apptRepo.GetAll();
        }

        private Appointment CollectInput()
        {
            return new Appointment
            {
                AppointmentId = string.IsNullOrWhiteSpace(txtApptId.Text) ? 0 : int.Parse(txtApptId.Text),
                PetId = (int)cmbPet.SelectedValue,
                ApptTime = dtApptTime.Value,
                Reason = cmbReason.Text.Trim(),
                Status = cmbStatus.Text
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPet.SelectedValue == null)
            {
                MessageBox.Show("Please select a Pet.");
                return;
            }

            _apptRepo.Insert(CollectInput());
            MessageBox.Show("New appointment added!");

            LoadAppointments();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtApptId.Text == "")
            {
                MessageBox.Show("Select an appointment from the list.");
                return;
            }

            _apptRepo.Update(CollectInput());
            MessageBox.Show("Appointment updated!");

            LoadAppointments();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtApptId.Text == "")
            {
                MessageBox.Show("Select an appointment first.");
                return;
            }

            int id = int.Parse(txtApptId.Text);
            _apptRepo.Delete(id);

            MessageBox.Show("Appointment deleted.");
            LoadAppointments();
            ClearInputs();
        }

        private void dgvAppts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvAppts.Rows[e.RowIndex];

            txtApptId.Text = row.Cells["AppointmentId"].Value?.ToString();
            cmbPet.SelectedValue = row.Cells["PetId"].Value;

            dtApptTime.Value = (DateTime)row.Cells["ApptTime"].Value;

            cmbReason.Text = row.Cells["Reason"].Value?.ToString();
            cmbStatus.Text = row.Cells["Status"].Value?.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtApptId.Clear();
            cmbPet.SelectedIndex = 0;
            dtApptTime.Value = DateTime.Now;
            cmbReason.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }
    }
}
