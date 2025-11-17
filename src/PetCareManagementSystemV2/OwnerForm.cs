using Microsoft.Data.SqlClient;
using PetCareManagementSystemV2.Models;
using PetCareManagementSystemV2.Repositories;

namespace PetCareManagementSystemV2
{
    public partial class OwnerForm : Form
    {
        private readonly OwnerRepository _repo = new OwnerRepository();

        public OwnerForm()
        {
            InitializeComponent();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            LoadOwners();
        }

        private void LoadOwners()
        {
            var list = _repo.GetAll();
            dgvOwners.DataSource = list;
        }

        private Owner CollectInput()
        {
            return new Owner
            {
                OwnerId = string.IsNullOrEmpty(txtOwnerId.Text) ? 0 : int.Parse(txtOwnerId.Text),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                CreatedBy = null 
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.");
                return;
            }

            var owner = CollectInput();
            _repo.Insert(owner);

            MessageBox.Show("Owner added successfully!");
            LoadOwners();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwnerId.Text))
            {
                MessageBox.Show("Select an owner first.");
                return;
            }

            var owner = CollectInput();
            _repo.Update(owner);

            MessageBox.Show("Owner updated.");
            LoadOwners();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwnerId.Text))
            {
                MessageBox.Show("Select an owner first.");
                return;
            }

            int id = int.Parse(txtOwnerId.Text);
            _repo.Delete(id);

            MessageBox.Show("Owner deleted.");
            LoadOwners();
            ClearInputs();
        }

        private void dgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOwners.Rows[e.RowIndex];

                txtOwnerId.Text = row.Cells["OwnerId"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtOwnerId.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadOwners();
        }


    }
}
