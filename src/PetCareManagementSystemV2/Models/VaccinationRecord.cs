using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystemV2.Models
{
    public class VaccinationRecord
    {
        public int VaccinationId { get; set; }
        public int PetId { get; set; }
        public string VaccineName { get; set; } = "";
        public DateTime GivenDate { get; set; }
        public DateTime? NextDueDate { get; set; }
        public string Notes { get; set; } = "";
    }
}

