using PetCareManagementSystemV2.Models;
using PetCareManagementSystemV2.Repositories;

namespace PetCareManagementSystemV2
{
    public partial class VaccinationForm : Form
    {
        private readonly VaccinationRecordRepository _vaccRepo = new VaccinationRecordRepository();
        private readonly PetRepository _petRepo = new PetRepository();

        public VaccinationForm()
        {
            InitializeComponent();
        }

        private void VaccinationForm_Load(object sender, EventArgs e)
        {
            LoadPets();
            LoadVaccinations();
        }

        private void LoadPets()
        {
            var pets = _petRepo.GetAll();
            cmbPet.DataSource = pets;
            cmbPet.DisplayMember = "PetName";
            cmbPet.ValueMember = "PetId";
        }

        private void LoadVaccinations()
        {
            dgvVaccs.DataSource = _vaccRepo.GetAll();
        }

        private VaccinationRecord CollectInput()
        {
            return new VaccinationRecord
            {
                VaccinationId = string.IsNullOrWhiteSpace(txtVaccId.Text) ? 0 : int.Parse(txtVaccId.Text),
                PetId = (int)cmbPet.SelectedValue,
                VaccineName = txtVaccineName.Text.Trim(),
                GivenDate = dtGivenDate.Value,
                NextDueDate = dtNextDue.Checked ? dtNextDue.Value : null,
                Notes = txtNotes.Text.Trim()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVaccineName.Text.Trim() == "")
            {
                MessageBox.Show("Vaccine Name is required.");
                return;
            }

            _vaccRepo.Insert(CollectInput());
            MessageBox.Show("Record added!");

            LoadVaccinations();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtVaccId.Text == "")
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            _vaccRepo.Update(CollectInput());
            MessageBox.Show("Updated!");

            LoadVaccinations();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtVaccId.Text == "")
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            int id = int.Parse(txtVaccId.Text);
            _vaccRepo.Delete(id);

            MessageBox.Show("Deleted.");
            LoadVaccinations();
            ClearInputs();
        }

        private void dgvVaccs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvVaccs.Rows[e.RowIndex];

            txtVaccId.Text = row.Cells["VaccinationId"].Value?.ToString();
            cmbPet.SelectedValue = row.Cells["PetId"].Value;

            txtVaccineName.Text = row.Cells["VaccineName"].Value?.ToString();
            dtGivenDate.Value = (DateTime)row.Cells["GivenDate"].Value;

            if (row.Cells["NextDueDate"].Value == DBNull.Value)
                dtNextDue.Checked = false;
            else
            {
                dtNextDue.Checked = true;
                dtNextDue.Value = (DateTime)row.Cells["NextDueDate"].Value;
            }

            txtNotes.Text = row.Cells["Notes"].Value?.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtVaccId.Clear();
            cmbPet.SelectedIndex = 0;
            txtVaccineName.Clear();
            dtGivenDate.Value = DateTime.Now;
            dtNextDue.Checked = false;
            txtNotes.Clear();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadVaccinations();
        }
    }
}
