using PetCareManagementSystemV2.Models;
using PetCareManagementSystemV2.Repositories;

namespace PetCareManagementSystemV2
{
    public partial class PetForm : Form
    {
        private readonly PetRepository _petRepo = new PetRepository();
        private readonly OwnerRepository _ownerRepo = new OwnerRepository();

        public PetForm()
        {
            InitializeComponent();
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            LoadOwners();
            LoadPets();
        }

        private void LoadOwners()
        {
            var owners = _ownerRepo.GetAll();
            cmbOwner.DataSource = owners;
            cmbOwner.DisplayMember = "FullName";
            cmbOwner.ValueMember = "OwnerId";
        }

        private void LoadPets()
        {
            dgvPets.DataSource = _petRepo.GetAll();
        }

        private Pet CollectInput()
        {
            return new Pet
            {
                PetId = string.IsNullOrWhiteSpace(txtPetId.Text) ? 0 : int.Parse(txtPetId.Text),
                OwnerId = (int)cmbOwner.SelectedValue,
                PetName = txtPetName.Text.Trim(),
                Species = txtSpecies.Text.Trim(),
                Breed = txtBreed.Text.Trim(),
                BirthDate = dtBirthDate.Checked ? dtBirthDate.Value : null,
                Notes = txtNotes.Text.Trim()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPetName.Text.Trim() == "")
            {
                MessageBox.Show("Pet name is required.");
                return;
            }

            _petRepo.Insert(CollectInput());
            MessageBox.Show("Pet added successfully!");

            LoadPets();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPetId.Text == "")
            {
                MessageBox.Show("Select a pet to update.");
                return;
            }

            _petRepo.Update(CollectInput());
            MessageBox.Show("Updated!");

            LoadPets();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPetId.Text == "")
            {
                MessageBox.Show("Select a pet to delete.");
                return;
            }

            int id = int.Parse(txtPetId.Text);
            _petRepo.Delete(id);

            MessageBox.Show("Deleted!");
            LoadPets();
            ClearInputs();
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvPets.Rows[e.RowIndex];

            txtPetId.Text = row.Cells["PetId"].Value?.ToString();
            cmbOwner.SelectedValue = row.Cells["OwnerId"].Value;
            txtPetName.Text = row.Cells["PetName"].Value?.ToString();
            txtSpecies.Text = row.Cells["Species"].Value?.ToString();
            txtBreed.Text = row.Cells["Breed"].Value?.ToString();

            if (row.Cells["BirthDate"].Value == DBNull.Value)
                dtBirthDate.Checked = false;
            else
            {
                dtBirthDate.Checked = true;
                dtBirthDate.Value = (DateTime)row.Cells["BirthDate"].Value;
            }

            txtNotes.Text = row.Cells["Notes"].Value?.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtPetId.Clear();
            txtPetName.Clear();
            txtSpecies.Clear();
            txtBreed.Clear();
            txtNotes.Clear();
            dtBirthDate.Checked = false;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadPets();
        }
    }
}

