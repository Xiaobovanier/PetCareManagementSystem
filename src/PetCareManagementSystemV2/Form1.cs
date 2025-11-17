namespace PetCareManagementSystemV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOwners_Click(object sender, EventArgs e)
        {
            OwnerForm f = new OwnerForm();
            f.ShowDialog();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            PetForm f = new PetForm();
            f.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm f = new AppointmentForm();
            f.ShowDialog();
        }

        private void btnVaccinations_Click(object sender, EventArgs e)
        {
            VaccinationForm f = new VaccinationForm();
            f.ShowDialog();
        }

        private void menuOwnerForm_Click(object sender, EventArgs e)
        {
            OwnerForm f = new OwnerForm();
            f.ShowDialog();
        }

        private void menuPetForm_Click(object sender, EventArgs e)
        {
            PetForm f = new PetForm();
            f.ShowDialog();
        }

        private void menuAppointmentForm_Click(object sender, EventArgs e)
        {
            AppointmentForm f = new AppointmentForm();
            f.ShowDialog();
        }

        private void menuVaccinationForm_Click(object sender, EventArgs e)
        {
            VaccinationForm f = new VaccinationForm();
            f.ShowDialog();
        }
    }
}
