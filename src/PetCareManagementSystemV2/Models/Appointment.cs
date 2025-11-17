using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystemV2.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PetId { get; set; }
        public DateTime ApptTime { get; set; }
        public string Reason { get; set; } = "";
        public string Status { get; set; } = "Scheduled";  // Scheduled / Completed / Cancelled
    }
}

